// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// 
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.Achievements
{
    public class AchievementReward
    {

        public AchievementMediaAsset MediaAsset
        {
            get;
            private set;
        }

        public Type ValuePropertyType
        {
            get;
            private set;
        }

        public AchievementRewardType RewardType
        {
            get;
            private set;
        }

        public string Data
        {
            get;
            private set;
        }

        public string Description
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

    }
}
