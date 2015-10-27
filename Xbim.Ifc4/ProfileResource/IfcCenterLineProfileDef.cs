// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProfileResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCenterLineProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCenterLineProfileDef : IIfcArbitraryOpenProfileDef
	{
		IfcPositiveLengthMeasure @Thickness { get; }
		
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IFCCENTERLINEPROFILEDEF", 475)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCenterLineProfileDef : IfcArbitraryOpenProfileDef, IInstantiableEntity, IIfcCenterLineProfileDef, IEqualityComparer<@IfcCenterLineProfileDef>, IEquatable<@IfcCenterLineProfileDef>
	{
		#region IIfcCenterLineProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcCenterLineProfileDef.Thickness { get { return @Thickness; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCenterLineProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _thickness;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @Thickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _thickness;
				((IPersistEntity)this).Activate(false);
				return _thickness;
			} 
			set
			{
				SetValue( v =>  _thickness = v, _thickness, value,  "Thickness");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_thickness = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCenterLineProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCenterLineProfileDef
            var root = (@IfcCenterLineProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCenterLineProfileDef left, @IfcCenterLineProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCenterLineProfileDef left, @IfcCenterLineProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCenterLineProfileDef x, @IfcCenterLineProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCenterLineProfileDef obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}