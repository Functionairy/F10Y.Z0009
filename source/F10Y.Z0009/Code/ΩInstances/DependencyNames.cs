using System;


namespace F10Y.Z0009
{
    public class DependencyNames : IDependencyNames
    {
        #region Infrastructure

        public static IDependencyNames Instance { get; } = new DependencyNames();


        private DependencyNames()
        {
        }

        #endregion
    }
}
