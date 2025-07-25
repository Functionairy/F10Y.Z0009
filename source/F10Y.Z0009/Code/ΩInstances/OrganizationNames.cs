using System;


namespace F10Y.Z0009
{
    public class OrganizationNames : IOrganizationNames
    {
        #region Infrastructure

        public static IOrganizationNames Instance { get; } = new OrganizationNames();


        private OrganizationNames()
        {
        }

        #endregion
    }
}
