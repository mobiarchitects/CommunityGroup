﻿using System;
namespace CommunityGroup.Interfaces
{
    public interface IToast
    {
        void LongAlert(string message);
        void ShortAlert(string message);
    }
}