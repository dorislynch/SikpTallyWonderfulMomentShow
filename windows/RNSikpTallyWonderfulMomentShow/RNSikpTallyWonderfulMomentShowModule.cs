using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Sikp.Tally.Wonderful.Moment.Show.RNSikpTallyWonderfulMomentShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSikpTallyWonderfulMomentShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSikpTallyWonderfulMomentShowModule"/>.
        /// </summary>
        internal RNSikpTallyWonderfulMomentShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSikpTallyWonderfulMomentShow";
            }
        }
    }
}
