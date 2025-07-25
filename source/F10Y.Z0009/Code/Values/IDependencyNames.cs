using System;

using F10Y.T0003;


namespace F10Y.Z0009
{
    /// <summary>
    /// Functionairy-applicable dependency names.
    /// </summary>
    [ValuesMarker]
    public partial interface IDependencyNames
    {
        /// <summary>
        /// <para><value>F10Y.L0000</value></para>
        /// .NET Standard 2.1 foundation library.
        /// </summary>
        public string F10Y_L0000 => "F10Y.L0000";

        /// <summary>
        /// <para><value>F10Y.T0003</value></para>
        /// Values marker attribute infrastructure types library.
        /// </summary>
        public string F10Y_T0003 => "F10Y.T0003";

        /// <summary>
        /// <para><value>F10Y.T0011</value></para>
        /// Survey marker attribute infrastructure types library.
        /// </summary>
        public string F10Y_T0011 => "F10Y.T0011";

        /// <summary>
        /// <para><value>F10Y.Y0000</value></para>
        /// C#/.NET Standard 2.1 documentation library.
        /// </summary>
        public string F10Y_Y0000 => "F10Y.Y0000";
    }
}
