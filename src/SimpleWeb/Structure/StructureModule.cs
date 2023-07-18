using Autofac;

namespace Structure
{
    public class StructureModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public StructureModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}
