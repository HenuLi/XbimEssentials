// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPcurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPcurve : IIfcCurve, IfcCurveOnSurface
	{
		IIfcSurface @BasisSurface { get; }
		IIfcCurve @ReferenceCurve { get; }
		
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IFCPCURVE", 793)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPcurve : IfcCurve, IInstantiableEntity, IIfcPcurve, IEqualityComparer<@IfcPcurve>, IEquatable<@IfcPcurve>
	{
		#region IIfcPcurve explicit implementation
		IIfcSurface IIfcPcurve.BasisSurface { get { return @BasisSurface; } }	
		IIfcCurve IIfcPcurve.ReferenceCurve { get { return @ReferenceCurve; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPcurve(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSurface _basisSurface;
		private IfcCurve _referenceCurve;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSurface @BasisSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _basisSurface;
				((IPersistEntity)this).Activate(false);
				return _basisSurface;
			} 
			set
			{
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurve @ReferenceCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _referenceCurve;
				((IPersistEntity)this).Activate(false);
				return _referenceCurve;
			} 
			set
			{
				SetValue( v =>  _referenceCurve = v, _referenceCurve, value,  "ReferenceCurve");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisSurface = (IfcSurface)(value.EntityVal);
					return;
				case 1: 
					_referenceCurve = (IfcCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*DimIs2D:	DimIs2D : ReferenceCurve.Dim = 2;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPcurve other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPcurve
            var root = (@IfcPcurve)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPcurve left, @IfcPcurve right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPcurve left, @IfcPcurve right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPcurve x, @IfcPcurve y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPcurve obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}