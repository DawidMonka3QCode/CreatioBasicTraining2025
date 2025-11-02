namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtServiceSchema

	/// <exclude/>
	public class UsrYachtServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtServiceSchema(UsrYachtServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae1dcfce-9980-4ab7-be3c-57945187f9da");
			Name = "UsrYachtService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("46857d44-f558-43b6-b257-b7ae7345a80c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,208,215,207,173,84,72,206,79,73,5,0,130,231,21,128,10,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae1dcfce-9980-4ab7-be3c-57945187f9da"));
		}

		#endregion

	}

	#endregion

}

