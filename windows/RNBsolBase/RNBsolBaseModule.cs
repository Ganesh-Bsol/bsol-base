using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Bsol.Base.RNBsolBase
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBsolBaseModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBsolBaseModule"/>.
        /// </summary>
        internal RNBsolBaseModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBsolBase";
            }
        }
    }
}
