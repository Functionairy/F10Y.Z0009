using System;

using F10Y.T0003;


namespace F10Y.Z0009
{
    /// <summary>
    /// Functionairy-applicable organization names.
    /// </summary>
    [ValuesMarker]
    [DomainDescriptor(Z0008.IDomainNames.Organization_Names_Constant)]
    public partial interface IOrganizationNames
    {
        /// <summary>
        /// <para><value>F10Y</value></para>
        /// </summary>
        const string F10Y_Constant = "F10Y";

        /// <inheritdoc cref="F10Y_Constant"/>
        string F10Y => F10Y_Constant;
    }
}
