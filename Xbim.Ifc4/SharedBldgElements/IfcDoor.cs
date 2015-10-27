// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedBldgElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDoor
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDoor : IIfcBuildingElement
	{
		IfcPositiveLengthMeasure? @OverallHeight { get; }
		IfcPositiveLengthMeasure? @OverallWidth { get; }
		IfcDoorTypeEnum? @PredefinedType { get; }
		IfcDoorTypeOperationEnum? @OperationType { get; }
		IfcLabel? @UserDefinedOperationType { get; }
		
	}
}

namespace Xbim.Ifc4.SharedBldgElements
{
	[ExpressType("IFCDOOR", 581)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDoor : IfcBuildingElement, IInstantiableEntity, IIfcDoor, IEqualityComparer<@IfcDoor>, IEquatable<@IfcDoor>
	{
		#region IIfcDoor explicit implementation
		IfcPositiveLengthMeasure? IIfcDoor.OverallHeight { get { return @OverallHeight; } }	
		IfcPositiveLengthMeasure? IIfcDoor.OverallWidth { get { return @OverallWidth; } }	
		IfcDoorTypeEnum? IIfcDoor.PredefinedType { get { return @PredefinedType; } }	
		IfcDoorTypeOperationEnum? IIfcDoor.OperationType { get { return @OperationType; } }	
		IfcLabel? IIfcDoor.UserDefinedOperationType { get { return @UserDefinedOperationType; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _overallHeight;
		private IfcPositiveLengthMeasure? _overallWidth;
		private IfcDoorTypeEnum? _predefinedType;
		private IfcDoorTypeOperationEnum? _operationType;
		private IfcLabel? _userDefinedOperationType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @OverallHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _overallHeight;
				((IPersistEntity)this).Activate(false);
				return _overallHeight;
			} 
			set
			{
				SetValue( v =>  _overallHeight = v, _overallHeight, value,  "OverallHeight");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @OverallWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _overallWidth;
				((IPersistEntity)this).Activate(false);
				return _overallWidth;
			} 
			set
			{
				SetValue( v =>  _overallWidth = v, _overallWidth, value,  "OverallWidth");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDoorTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDoorTypeOperationEnum? @OperationType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _operationType;
				((IPersistEntity)this).Activate(false);
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedOperationType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedOperationType;
				((IPersistEntity)this).Activate(false);
				return _userDefinedOperationType;
			} 
			set
			{
				SetValue( v =>  _userDefinedOperationType = v, _userDefinedOperationType, value,  "UserDefinedOperationType");
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_overallHeight = value.RealVal;
					return;
				case 9: 
					_overallWidth = value.RealVal;
					return;
				case 10: 
                    _predefinedType = (IfcDoorTypeEnum) System.Enum.Parse(typeof (IfcDoorTypeEnum), value.EnumVal, true);
					return;
				case 11: 
                    _operationType = (IfcDoorTypeOperationEnum) System.Enum.Parse(typeof (IfcDoorTypeOperationEnum), value.EnumVal, true);
					return;
				case 12: 
					_userDefinedOperationType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectStyleAssigned:                             OR ('IFC4.IFCDOORTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDoor other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDoor
            var root = (@IfcDoor)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDoor left, @IfcDoor right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDoor left, @IfcDoor right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDoor x, @IfcDoor y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDoor obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}