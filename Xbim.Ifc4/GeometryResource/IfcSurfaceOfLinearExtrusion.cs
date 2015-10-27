// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProfileResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceOfLinearExtrusion
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceOfLinearExtrusion : IIfcSweptSurface
	{
		IIfcDirection @ExtrudedDirection { get; }
		IfcLengthMeasure @Depth { get; }
		
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IFCSURFACEOFLINEAREXTRUSION", 1056)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceOfLinearExtrusion : IfcSweptSurface, IInstantiableEntity, IIfcSurfaceOfLinearExtrusion, IEqualityComparer<@IfcSurfaceOfLinearExtrusion>, IEquatable<@IfcSurfaceOfLinearExtrusion>
	{
		#region IIfcSurfaceOfLinearExtrusion explicit implementation
		IIfcDirection IIfcSurfaceOfLinearExtrusion.ExtrudedDirection { get { return @ExtrudedDirection; } }	
		IfcLengthMeasure IIfcSurfaceOfLinearExtrusion.Depth { get { return @Depth; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceOfLinearExtrusion(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _extrudedDirection;
		private IfcLengthMeasure _depth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDirection @ExtrudedDirection 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _extrudedDirection;
				((IPersistEntity)this).Activate(false);
				return _extrudedDirection;
			} 
			set
			{
				SetValue( v =>  _extrudedDirection = v, _extrudedDirection, value,  "ExtrudedDirection");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure @Depth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _depth;
				((IPersistEntity)this).Activate(false);
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_extrudedDirection = (IfcDirection)(value.EntityVal);
					return;
				case 3: 
					_depth = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*DepthGreaterZero:	DepthGreaterZero : Depth > 0.;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceOfLinearExtrusion other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceOfLinearExtrusion
            var root = (@IfcSurfaceOfLinearExtrusion)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceOfLinearExtrusion left, @IfcSurfaceOfLinearExtrusion right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceOfLinearExtrusion left, @IfcSurfaceOfLinearExtrusion right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSurfaceOfLinearExtrusion x, @IfcSurfaceOfLinearExtrusion y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSurfaceOfLinearExtrusion obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}