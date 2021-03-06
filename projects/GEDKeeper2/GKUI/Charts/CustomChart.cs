﻿/*
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
using GKCommon.Controls;
using GKCore;

namespace GKUI.Charts
{
    public abstract class CustomChart : GKScrollableControl
    {
        private static readonly object EventNavRefresh;


        private readonly NavigationStack fNavman;


        public event EventHandler NavRefresh
        {
            add { base.Events.AddHandler(CustomChart.EventNavRefresh, value); }
            remove { base.Events.RemoveHandler(CustomChart.EventNavRefresh, value); }
        }


        static CustomChart()
        {
            CustomChart.EventNavRefresh = new object();
        }

        protected CustomChart() : base()
        {
            this.fNavman = new NavigationStack();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.fNavman != null) this.fNavman.Dispose();
            }
            base.Dispose(disposing);
        }

        private void DoNavRefresh()
        {
            EventHandler eventHandler = (EventHandler)base.Events[CustomChart.EventNavRefresh];
            if (eventHandler == null) return;

            eventHandler(this, null);
        }


        protected abstract void SetNavObject(object obj);


        public bool NavAdd(object obj)
        {
            if (obj != null && !this.fNavman.Busy) {
                this.fNavman.Current = obj;
                return true;
            }
            return false;
        }

        public bool NavCanBackward()
        {
            return this.fNavman.CanBackward();
        }

        public bool NavCanForward()
        {
            return this.fNavman.CanForward();
        }

        public void NavNext()
        {
            if (!this.fNavman.CanForward()) return;

            this.fNavman.BeginNav();
            try
            {
                this.SetNavObject(this.fNavman.Next());
                this.DoNavRefresh();
            }
            finally
            {
                this.fNavman.EndNav();
            }
        }

        public void NavPrev()
        {
            if (!this.fNavman.CanBackward()) return;

            this.fNavman.BeginNav();
            try
            {
                this.SetNavObject(this.fNavman.Back());
                this.DoNavRefresh();
            }
            finally
            {
                this.fNavman.EndNav();
            }
        }
    }
}
