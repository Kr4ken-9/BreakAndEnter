﻿using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API.Collections;

namespace ExtraConcentratedJuice.BreakAndEnter
{
    public class BreakAndEnter : RocketPlugin
    {
        public static BreakAndEnter instance;

        protected override void Load()
        {
            instance = this;
            
            // Hello by name is Sven and your name sucks because it's just three random words combined
            // I had to paraphrase because I couldn't find the picture
            // Now merge my PR already
            Logger.Log("BreakAndEnter by ExtraConcatenatedJuice loaded");
            Logger.Log("For help please visit https://iceplugins.xyz/BreakAndEnter/");
        }

        public override TranslationList DefaultTranslations =>
            new TranslationList
            {
                { "no_object", "No object was found in your line of sight." },
                { "structure_removed", "Structure removed successfully." },
                { "barricade_removed", "Barricade removed successfully." },
                { "invalid_destroy", "The object that you are looking at is not a barricade nor a structure." },
                { "invalid_door", "The object that you are looking at is not a door." },
                { "door_toggle", "Door {0}." },
                { "storage_open", "Opened storage." },
                { "invalid_storage", "The object that you are looking at is not a storage unit." }
            };
    }
}
