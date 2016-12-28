using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	public partial class IfcStructuralSurfaceAction : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.StructuralAnalysisDomain.IfcStructuralSurfaceAction");

		/// <summary>
		/// Tests the express where clause ProjectedIsGlobal
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ProjectedIsGlobal() {
			var retVal = false;
			try {
				retVal = (!EXISTS(ProjectedOrTrue)) || ((ProjectedOrTrue != IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH) || (this/* as IfcStructuralActivity*/.GlobalOrLocal == IfcGlobalOrLocalEnum.GLOBAL_COORDS));
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'ProjectedIsGlobal' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		/// <summary>
		/// Tests the express where clause HasObjectType
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool HasObjectType() {
			var retVal = false;
			try {
				retVal = (PredefinedType != IfcStructuralSurfaceActivityTypeEnum.USERDEFINED) || EXISTS(this/* as IfcObject*/.ObjectType);
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'HasObjectType' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		public new IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ProjectedIsGlobal())
				yield return new ValidationResult() { Item = this, IssueSource = "ProjectedIsGlobal", IssueType = ValidationFlags.EntityWhereClauses };
			if (!HasObjectType())
				yield return new ValidationResult() { Item = this, IssueSource = "HasObjectType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}