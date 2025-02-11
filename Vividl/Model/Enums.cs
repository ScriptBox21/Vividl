﻿
using System.ComponentModel;

namespace Vividl.Model
{
    /// <summary>
    /// Specifies the possible outcomes of a download process.
    /// </summary>
    public enum DownloadResult
    {
        Success, Cancelled, Failed
    }

    /// <summary>
    /// Specifies the possible states of a download item
    /// according to which its appearance in the list changes.
    /// </summary>
    public enum ItemState
    {
        None, Fetched, Downloading, Succeeded
    }

    /// <summary>
    /// Specifies available application themes.
    /// </summary>
    public enum Theme
    {
        Light, Dark
    }

    /// <summary>
    /// Specifies the possible options to handle (re-)downloads of items with the same file name.
    /// </summary>
    public enum OverwriteMode
    {
        [Description("OverwriteMode_None")]
        None,
        [Description("OverwriteMode_Overwrite")]
        Overwrite,
        [Description("OverwriteMode_Increment")]
        Increment
    }

    /// <summary>
    /// Specifies the possible hardware acceleration configurations.
    /// </summary>
    public enum HwAccelMode
    {
        [Description("HwAccelMode_None")]
        None,
        [Description("HwAccelMode_NvidiaCuda")]
        NvidiaCuda,
        [Description("HwAccelMode_AmdAmf")]
        AmdAmf,
        [Description("HwAccelMode_IntelQsv")]
        IntelQsv,
    }
}
