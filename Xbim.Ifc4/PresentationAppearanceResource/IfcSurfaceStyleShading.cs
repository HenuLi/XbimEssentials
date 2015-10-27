// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceStyleShading
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceStyleShading : IIfcPresentationItem, IfcSurfaceStyleElementSelect
	{
		IIfcColourRgb @SurfaceColour { get; }
		
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCSURFACESTYLESHADING", 1063)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleShading : IfcPresentationItem, IInstantiableEntity, IIfcSurfaceStyleShading, IEqualityComparer<@IfcSurfaceStyleShading>, IEquatable<@IfcSurfaceStyleShading>
	{
		#region IIfcSurfaceStyleShading explicit implementation
		IIfcColourRgb IIfcSurfaceStyleShading.SurfaceColour { get { return @SurfaceColour; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyleShading(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcColourRgb _surfaceColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourRgb @SurfaceColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _surfaceColour;
				((IPersistEntity)this).Activate(false);
				return _surfaceColour;
			} 
			set
			{
				SetValue( v =>  _surfaceColour = v, _surfaceColour, value,  "SurfaceColour");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_surfaceColour = (IfcColourRgb)(value.EntityVal);
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
        public bool Equals(@IfcSurfaceStyleShading other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceStyleShading
            var root = (@IfcSurfaceStyleShading)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceStyleShading left, @IfcSurfaceStyleShading right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceStyleShading left, @IfcSurfaceStyleShading right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSurfaceStyleShading x, @IfcSurfaceStyleShading y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSurfaceStyleShading obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}