// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelDefinesByType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelDefinesByType : IIfcRelDefines
	{
		IEnumerable<IIfcObject> @RelatedObjects { get; }
		IIfcTypeObject @RelatingType { get; }
		
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCRELDEFINESBYTYPE", 935)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDefinesByType : IfcRelDefines, IInstantiableEntity, IIfcRelDefinesByType, IEqualityComparer<@IfcRelDefinesByType>, IEquatable<@IfcRelDefinesByType>
	{
		#region IIfcRelDefinesByType explicit implementation
		IEnumerable<IIfcObject> IIfcRelDefinesByType.RelatedObjects { get { return @RelatedObjects; } }	
		IIfcTypeObject IIfcRelDefinesByType.RelatingType { get { return @RelatingType; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDefinesByType(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedObjects = new ItemSet<IfcObject>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcObject> _relatedObjects;
		private IfcTypeObject _relatingType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcObject> @RelatedObjects 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedObjects;
				((IPersistEntity)this).Activate(false);
				return _relatedObjects;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcTypeObject @RelatingType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingType;
				((IPersistEntity)this).Activate(false);
				return _relatingType;
			} 
			set
			{
				SetValue( v =>  _relatingType = v, _relatingType, value,  "RelatingType");
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
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					if (_relatedObjects == null) _relatedObjects = new ItemSet<IfcObject>( this );
					_relatedObjects.InternalAdd((IfcObject)value.EntityVal);
					return;
				case 5: 
					_relatingType = (IfcTypeObject)(value.EntityVal);
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
        public bool Equals(@IfcRelDefinesByType other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelDefinesByType
            var root = (@IfcRelDefinesByType)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelDefinesByType left, @IfcRelDefinesByType right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelDefinesByType left, @IfcRelDefinesByType right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelDefinesByType x, @IfcRelDefinesByType y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelDefinesByType obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}