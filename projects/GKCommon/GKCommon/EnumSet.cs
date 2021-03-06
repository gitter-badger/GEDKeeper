/*
 *  "GEDKeeper", the personal genealogical database editor.
 *  Copyright (C) 2009-2016 by Serg V. Zhdanovskih (aka Alchemist, aka Norseman).
 *
 *  This file is part of "GEDKeeper".
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Runtime.InteropServices;

namespace GKCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct EnumSet<T> : ICloneable where T : IComparable, IFormattable, IConvertible
    {
        private byte[] data;

        public static EnumSet<T> Create(params T[] args)
        {
            EnumSet<T> result = new EnumSet<T>();
            result.data = new byte[32];
            result.Include(args);
            return result;
        }

        public void Include(params T[] e)
        {
            if (e == null) return;

            for (int i = 0; i < e.Length; i++) {
                this.Include(e[i]);
            }
        }

        public void Include(T elem)
        {
            byte idx = ((IConvertible)elem).ToByte(null);
            this.data[(idx >> 3)] = (byte)(this.data[(idx >> 3)] | (1 << (int)(idx & 7u)));
        }

        public void Exclude(T elem)
        {
            byte idx = ((IConvertible)elem).ToByte(null);
            this.data[(idx >> 3)] = (byte)(this.data[(idx >> 3)] & (~(1 << (int)(idx & 7u))));
        }

        public bool Contains(T elem)
        {
            byte idx = ((IConvertible)elem).ToByte(null);
            return ((uint)this.data[(idx >> 3)] & (1 << (int)(idx & 7u))) > 0u;
        }

        public bool ContainsAll(params T[] e)
        {
            if (e == null || e.Length == 0) return false;

            for (int i = 0; i < e.Length; i++) {
                if (!this.Contains(e[i])) {
                    return false;
                }
            }
            return true;
        }

        public bool HasIntersect(params T[] e)
        {
            if (e == null || e.Length == 0) return false;

            for (int i = 0; i < e.Length; i++) {
                if (this.Contains(e[i])) {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            for (int i = 0; i <= 31; i++) {
                this.data[i] = 0;
            }
        }

        public bool IsEmpty()
        {
            for (int i = 0; i <= 31; i++) {
                if (this.data[i] != 0) {
                    return false;
                }
            }
            return true;
        }

        public static bool operator ==(EnumSet<T> left, EnumSet<T> right)
        {
            for (int I = 0; I <= 31; I++) {
                if (left.data[I] != right.data[I]) {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(EnumSet<T> left, EnumSet<T> right)
        {
            return !(left == right);
        }

        public static EnumSet<T> operator +(EnumSet<T> left, EnumSet<T> right)
        {
            EnumSet<T> result = left;
            for (int I = 0; I <= 31; I++) {
                result.data[I] |= right.data[I];
            }
            return result;
        }

        public static EnumSet<T> operator -(EnumSet<T> left, EnumSet<T> right)
        {
            EnumSet<T> result = left;
            for (int I = 0; I <= 31; I++) {
                result.data[I] = (byte)(result.data[I] & (~right.data[I]));
            }
            return result;
        }

        public static EnumSet<T> operator *(EnumSet<T> left, EnumSet<T> right)
        {
            EnumSet<T> result = left;
            for (int I = 0; I <= 31; I++) {
                result.data[I] &= right.data[I];
            }
            return result;
        }

        public string ByteToStr(int index)
        {
            byte val = this.data[index];

            uint bt = 1;
            string res = "";

            for (int i = 1; i <= 8; i++) {
                if ((val & bt) > 0) {
                    res = "1" + res;
                } else {
                    res = "0" + res;
                }

                bt = bt << 1;
            }

            return res;
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i <= 31; i++) {
                string bt = this.ByteToStr(i);
                res = bt + res;
            }
            return res;
        }

        public override int GetHashCode()
        {
            return this.data.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is EnumSet<T>)) return false;

            EnumSet<T> setObj = (EnumSet<T>)obj;
            return (this == setObj);
        }

        // ICloneable
        public object Clone()
        {
            EnumSet<T> result = new EnumSet<T>();
            result.data = new byte[32];
            Array.Copy(this.data, result.data, 32);
            return result;
        }
    }
}
