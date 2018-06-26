// Copyright (c) 2018 RocketChicken Interactive Inc.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

using Motive.Core.Scripting;
using Motive.Core.Json;
using Motive.Core.Models;

namespace Motive.Gaming.Models
{
    public class PlayableContentBatch : ScriptResource, IMediaItemProvider
    {
        public PlayableContent[] Playables { get; set; }

        public PlayableContentBatch()
            : base("motive.gaming.playableContentBatch")
        {
        }

        public void GetMediaItems(IList<Motive.Core.Media.MediaItem> items)
        {
            if (Playables != null)
            {
                foreach (var pc in Playables)
                {
                    pc.GetMediaItems(items);
                }
            }
        }
    }

    /// <summary>
    /// Represents content that will be "played" directly.
    /// </summary>
    public class PlayableContent : ScriptResource, IMediaItemProvider
    {
        public PlayableContent() : base("motive.gaming.playableContent")
        {
        }

        public ScriptTimer Timer { get; set; }

        public IScriptObject Content { get; set; }

        public string Route { get; set; }
        public string Priority { get; set; }

        public void GetMediaItems(IList<Motive.Core.Media.MediaItem> items)
        {
            if (Content != null && Content is IMediaItemProvider)
            {
                ((IMediaItemProvider)Content).GetMediaItems(items);
            }
        }
    }
}