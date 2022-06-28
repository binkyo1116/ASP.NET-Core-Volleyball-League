﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.7.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using TournamentManager.DAL.HelperClasses;
using TournamentManager.DAL.FactoryClasses;
using TournamentManager.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace TournamentManager.DAL.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'SetRule'.<br/><br/></summary>
	[Serializable]
	public partial class SetRuleEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<RoundEntity> _rounds;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static SetRuleEntityStaticMetaData _staticMetaData = new SetRuleEntityStaticMetaData();
		private static SetRuleRelations _relationsFactory = new SetRuleRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Rounds</summary>
			public static readonly string Rounds = "Rounds";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class SetRuleEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public SetRuleEntityStaticMetaData()
			{
				SetEntityCoreInfo("SetRuleEntity", InheritanceHierarchyType.None, false, (int)TournamentManager.DAL.EntityType.SetRuleEntity, typeof(SetRuleEntity), typeof(SetRuleEntityFactory), false);
				AddNavigatorMetaData<SetRuleEntity, EntityCollection<RoundEntity>>("Rounds", a => a._rounds, (a, b) => a._rounds = b, a => a.Rounds, () => new SetRuleRelations().RoundEntityUsingSetRuleId, typeof(RoundEntity), (int)TournamentManager.DAL.EntityType.RoundEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static SetRuleEntity()
		{
		}

		/// <summary> CTor</summary>
		public SetRuleEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SetRuleEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SetRuleEntity</param>
		public SetRuleEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for SetRule which data should be fetched into this SetRule object</param>
		public SetRuleEntity(System.Int64 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for SetRule which data should be fetched into this SetRule object</param>
		/// <param name="validator">The custom validator object for this SetRuleEntity</param>
		public SetRuleEntity(System.Int64 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SetRuleEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Round' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRounds() { return CreateRelationInfoForNavigator("Rounds"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SetRuleEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static SetRuleRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Round' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRounds { get { return _staticMetaData.GetPrefetchPathElement("Rounds", CommonEntityBase.CreateEntityCollection<RoundEntity>()); } }

		/// <summary>The CreatedOn property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."CreatedOn".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreatedOn
		{
			get { return (System.DateTime)GetValue((int)SetRuleFieldIndex.CreatedOn, true); }
			set	{ SetValue((int)SetRuleFieldIndex.CreatedOn, value); }
		}

		/// <summary>The Id property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."Id".<br/>Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)SetRuleFieldIndex.Id, true); }
			set { SetValue((int)SetRuleFieldIndex.Id, value); }		}

		/// <summary>The MaxSubstitutions property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."MaxSubstitutions".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 MaxSubstitutions
		{
			get { return (System.Int32)GetValue((int)SetRuleFieldIndex.MaxSubstitutions, true); }
			set	{ SetValue((int)SetRuleFieldIndex.MaxSubstitutions, value); }
		}

		/// <summary>The MaxTimeouts property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."MaxTimeouts".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 MaxTimeouts
		{
			get { return (System.Int32)GetValue((int)SetRuleFieldIndex.MaxTimeouts, true); }
			set	{ SetValue((int)SetRuleFieldIndex.MaxTimeouts, value); }
		}

		/// <summary>The ModifiedOn property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."ModifiedOn".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedOn
		{
			get { return (System.DateTime)GetValue((int)SetRuleFieldIndex.ModifiedOn, true); }
			set	{ SetValue((int)SetRuleFieldIndex.ModifiedOn, value); }
		}

		/// <summary>The Name property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 255.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SetRuleFieldIndex.Name, true); }
			set	{ SetValue((int)SetRuleFieldIndex.Name, value); }
		}

		/// <summary>The NumOfPointsToWinRegular property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."NumOfPointsToWinRegular".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 NumOfPointsToWinRegular
		{
			get { return (System.Int32)GetValue((int)SetRuleFieldIndex.NumOfPointsToWinRegular, true); }
			set	{ SetValue((int)SetRuleFieldIndex.NumOfPointsToWinRegular, value); }
		}

		/// <summary>The NumOfPointsToWinTiebreak property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."NumOfPointsToWinTiebreak".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 NumOfPointsToWinTiebreak
		{
			get { return (System.Int32)GetValue((int)SetRuleFieldIndex.NumOfPointsToWinTiebreak, true); }
			set	{ SetValue((int)SetRuleFieldIndex.NumOfPointsToWinTiebreak, value); }
		}

		/// <summary>The PointsDiffToWinRegular property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."PointsDiffToWinRegular".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 PointsDiffToWinRegular
		{
			get { return (System.Int32)GetValue((int)SetRuleFieldIndex.PointsDiffToWinRegular, true); }
			set	{ SetValue((int)SetRuleFieldIndex.PointsDiffToWinRegular, value); }
		}

		/// <summary>The PointsDiffToWinTiebreak property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."PointsDiffToWinTiebreak".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 PointsDiffToWinTiebreak
		{
			get { return (System.Int32)GetValue((int)SetRuleFieldIndex.PointsDiffToWinTiebreak, true); }
			set	{ SetValue((int)SetRuleFieldIndex.PointsDiffToWinTiebreak, value); }
		}

		/// <summary>The PointsSetLost property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."PointsSetLost".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 PointsSetLost
		{
			get { return (System.Int32)GetValue((int)SetRuleFieldIndex.PointsSetLost, true); }
			set	{ SetValue((int)SetRuleFieldIndex.PointsSetLost, value); }
		}

		/// <summary>The PointsSetTie property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."PointsSetTie".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 PointsSetTie
		{
			get { return (System.Int32)GetValue((int)SetRuleFieldIndex.PointsSetTie, true); }
			set	{ SetValue((int)SetRuleFieldIndex.PointsSetTie, value); }
		}

		/// <summary>The PointsSetWon property of the Entity SetRule<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SetRule"."PointsSetWon".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 PointsSetWon
		{
			get { return (System.Int32)GetValue((int)SetRuleFieldIndex.PointsSetWon, true); }
			set	{ SetValue((int)SetRuleFieldIndex.PointsSetWon, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'RoundEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RoundEntity))]
		public virtual EntityCollection<RoundEntity> Rounds { get { return GetOrCreateEntityCollection<RoundEntity, RoundEntityFactory>("SetRule", true, false, ref _rounds); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace TournamentManager.DAL
{
	public enum SetRuleFieldIndex
	{
		///<summary>CreatedOn. </summary>
		CreatedOn,
		///<summary>Id. </summary>
		Id,
		///<summary>MaxSubstitutions. </summary>
		MaxSubstitutions,
		///<summary>MaxTimeouts. </summary>
		MaxTimeouts,
		///<summary>ModifiedOn. </summary>
		ModifiedOn,
		///<summary>Name. </summary>
		Name,
		///<summary>NumOfPointsToWinRegular. </summary>
		NumOfPointsToWinRegular,
		///<summary>NumOfPointsToWinTiebreak. </summary>
		NumOfPointsToWinTiebreak,
		///<summary>PointsDiffToWinRegular. </summary>
		PointsDiffToWinRegular,
		///<summary>PointsDiffToWinTiebreak. </summary>
		PointsDiffToWinTiebreak,
		///<summary>PointsSetLost. </summary>
		PointsSetLost,
		///<summary>PointsSetTie. </summary>
		PointsSetTie,
		///<summary>PointsSetWon. </summary>
		PointsSetWon,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TournamentManager.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SetRule. </summary>
	public partial class SetRuleRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between SetRuleEntity and RoundEntity over the 1:n relation they have, using the relation between the fields: SetRule.Id - Round.SetRuleId</summary>
		public virtual IEntityRelation RoundEntityUsingSetRuleId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Rounds", true, new[] { SetRuleFields.Id, RoundFields.SetRuleId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSetRuleRelations
	{
		internal static readonly IEntityRelation RoundEntityUsingSetRuleIdStatic = new SetRuleRelations().RoundEntityUsingSetRuleId;

		/// <summary>CTor</summary>
		static StaticSetRuleRelations() { }
	}
}
