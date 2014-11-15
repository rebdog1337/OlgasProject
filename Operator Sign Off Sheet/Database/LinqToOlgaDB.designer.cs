﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Operator_Sign_Off_Sheet.Database
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OlgasProject")]
	public partial class LinqToOlgaDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertJobsTbl(JobsTbl instance);
    partial void UpdateJobsTbl(JobsTbl instance);
    partial void DeleteJobsTbl(JobsTbl instance);
    partial void InsertChoice(Choice instance);
    partial void UpdateChoice(Choice instance);
    partial void DeleteChoice(Choice instance);
    partial void InsertOperator(Operator instance);
    partial void UpdateOperator(Operator instance);
    partial void DeleteOperator(Operator instance);
    partial void InsertPreFirstBoard(PreFirstBoard instance);
    partial void UpdatePreFirstBoard(PreFirstBoard instance);
    partial void DeletePreFirstBoard(PreFirstBoard instance);
    #endregion
		
		public LinqToOlgaDBDataContext() : 
				base(global::Operator_Sign_Off_Sheet.Properties.Settings.Default.OlgasProjectConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToOlgaDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToOlgaDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToOlgaDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToOlgaDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<JobsTbl> JobsTbls
		{
			get
			{
				return this.GetTable<JobsTbl>();
			}
		}
		
		public System.Data.Linq.Table<Choice> Choices
		{
			get
			{
				return this.GetTable<Choice>();
			}
		}
		
		public System.Data.Linq.Table<Operator> Operators
		{
			get
			{
				return this.GetTable<Operator>();
			}
		}
		
		public System.Data.Linq.Table<PreFirstBoard> PreFirstBoards
		{
			get
			{
				return this.GetTable<PreFirstBoard>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.JobsTbl")]
	public partial class JobsTbl : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _JobID;
		
		private int _BatchNumber;
		
		private System.DateTime _Date;
		
		private string _JobIssue;
		
		private string _SMIssue;
		
		private string _PasteType;
		
		private string _PCBSide;
		
		private string _TypeOf1stOff;
		
		private int _ChangeNotes;
		
		private int _CCP;
		
		private int _ERMN;
		
		private System.Nullable<int> _LineNo;
		
		private System.Nullable<int> _JobNumber;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnJobIDChanging(int value);
    partial void OnJobIDChanged();
    partial void OnBatchNumberChanging(int value);
    partial void OnBatchNumberChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnJobIssueChanging(string value);
    partial void OnJobIssueChanged();
    partial void OnSMIssueChanging(string value);
    partial void OnSMIssueChanged();
    partial void OnPasteTypeChanging(string value);
    partial void OnPasteTypeChanged();
    partial void OnPCBSideChanging(string value);
    partial void OnPCBSideChanged();
    partial void OnTypeOf1stOffChanging(string value);
    partial void OnTypeOf1stOffChanged();
    partial void OnChangeNotesChanging(int value);
    partial void OnChangeNotesChanged();
    partial void OnCCPChanging(int value);
    partial void OnCCPChanged();
    partial void OnERMNChanging(int value);
    partial void OnERMNChanged();
    partial void OnLineNoChanging(System.Nullable<int> value);
    partial void OnLineNoChanged();
    partial void OnJobNumberChanging(System.Nullable<int> value);
    partial void OnJobNumberChanged();
    #endregion
		
		public JobsTbl()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int JobID
		{
			get
			{
				return this._JobID;
			}
			set
			{
				if ((this._JobID != value))
				{
					this.OnJobIDChanging(value);
					this.SendPropertyChanging();
					this._JobID = value;
					this.SendPropertyChanged("JobID");
					this.OnJobIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BatchNumber", DbType="Int NOT NULL")]
		public int BatchNumber
		{
			get
			{
				return this._BatchNumber;
			}
			set
			{
				if ((this._BatchNumber != value))
				{
					this.OnBatchNumberChanging(value);
					this.SendPropertyChanging();
					this._BatchNumber = value;
					this.SendPropertyChanged("BatchNumber");
					this.OnBatchNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobIssue", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string JobIssue
		{
			get
			{
				return this._JobIssue;
			}
			set
			{
				if ((this._JobIssue != value))
				{
					this.OnJobIssueChanging(value);
					this.SendPropertyChanging();
					this._JobIssue = value;
					this.SendPropertyChanged("JobIssue");
					this.OnJobIssueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SMIssue", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SMIssue
		{
			get
			{
				return this._SMIssue;
			}
			set
			{
				if ((this._SMIssue != value))
				{
					this.OnSMIssueChanging(value);
					this.SendPropertyChanging();
					this._SMIssue = value;
					this.SendPropertyChanged("SMIssue");
					this.OnSMIssueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasteType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PasteType
		{
			get
			{
				return this._PasteType;
			}
			set
			{
				if ((this._PasteType != value))
				{
					this.OnPasteTypeChanging(value);
					this.SendPropertyChanging();
					this._PasteType = value;
					this.SendPropertyChanged("PasteType");
					this.OnPasteTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PCBSide", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PCBSide
		{
			get
			{
				return this._PCBSide;
			}
			set
			{
				if ((this._PCBSide != value))
				{
					this.OnPCBSideChanging(value);
					this.SendPropertyChanging();
					this._PCBSide = value;
					this.SendPropertyChanged("PCBSide");
					this.OnPCBSideChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeOf1stOff", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TypeOf1stOff
		{
			get
			{
				return this._TypeOf1stOff;
			}
			set
			{
				if ((this._TypeOf1stOff != value))
				{
					this.OnTypeOf1stOffChanging(value);
					this.SendPropertyChanging();
					this._TypeOf1stOff = value;
					this.SendPropertyChanged("TypeOf1stOff");
					this.OnTypeOf1stOffChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChangeNotes", DbType="Int NOT NULL")]
		public int ChangeNotes
		{
			get
			{
				return this._ChangeNotes;
			}
			set
			{
				if ((this._ChangeNotes != value))
				{
					this.OnChangeNotesChanging(value);
					this.SendPropertyChanging();
					this._ChangeNotes = value;
					this.SendPropertyChanged("ChangeNotes");
					this.OnChangeNotesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CCP", DbType="Int NOT NULL")]
		public int CCP
		{
			get
			{
				return this._CCP;
			}
			set
			{
				if ((this._CCP != value))
				{
					this.OnCCPChanging(value);
					this.SendPropertyChanging();
					this._CCP = value;
					this.SendPropertyChanged("CCP");
					this.OnCCPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ERMN", DbType="Int NOT NULL")]
		public int ERMN
		{
			get
			{
				return this._ERMN;
			}
			set
			{
				if ((this._ERMN != value))
				{
					this.OnERMNChanging(value);
					this.SendPropertyChanging();
					this._ERMN = value;
					this.SendPropertyChanged("ERMN");
					this.OnERMNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[LineNo]", Storage="_LineNo", DbType="Int")]
		public System.Nullable<int> LineNo
		{
			get
			{
				return this._LineNo;
			}
			set
			{
				if ((this._LineNo != value))
				{
					this.OnLineNoChanging(value);
					this.SendPropertyChanging();
					this._LineNo = value;
					this.SendPropertyChanged("LineNo");
					this.OnLineNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobNumber", DbType="Int")]
		public System.Nullable<int> JobNumber
		{
			get
			{
				return this._JobNumber;
			}
			set
			{
				if ((this._JobNumber != value))
				{
					this.OnJobNumberChanging(value);
					this.SendPropertyChanging();
					this._JobNumber = value;
					this.SendPropertyChanged("JobNumber");
					this.OnJobNumberChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Choices")]
	public partial class Choice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ChoiceID;
		
		private string _ChoiceText;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnChoiceIDChanging(int value);
    partial void OnChoiceIDChanged();
    partial void OnChoiceTextChanging(string value);
    partial void OnChoiceTextChanged();
    #endregion
		
		public Choice()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChoiceID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ChoiceID
		{
			get
			{
				return this._ChoiceID;
			}
			set
			{
				if ((this._ChoiceID != value))
				{
					this.OnChoiceIDChanging(value);
					this.SendPropertyChanging();
					this._ChoiceID = value;
					this.SendPropertyChanged("ChoiceID");
					this.OnChoiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChoiceText", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ChoiceText
		{
			get
			{
				return this._ChoiceText;
			}
			set
			{
				if ((this._ChoiceText != value))
				{
					this.OnChoiceTextChanging(value);
					this.SendPropertyChanging();
					this._ChoiceText = value;
					this.SendPropertyChanged("ChoiceText");
					this.OnChoiceTextChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Operators")]
	public partial class Operator : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OperatorID;
		
		private string _OperatorName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOperatorIDChanging(int value);
    partial void OnOperatorIDChanged();
    partial void OnOperatorNameChanging(string value);
    partial void OnOperatorNameChanged();
    #endregion
		
		public Operator()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperatorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OperatorID
		{
			get
			{
				return this._OperatorID;
			}
			set
			{
				if ((this._OperatorID != value))
				{
					this.OnOperatorIDChanging(value);
					this.SendPropertyChanging();
					this._OperatorID = value;
					this.SendPropertyChanged("OperatorID");
					this.OnOperatorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperatorName", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string OperatorName
		{
			get
			{
				return this._OperatorName;
			}
			set
			{
				if ((this._OperatorName != value))
				{
					this.OnOperatorNameChanging(value);
					this.SendPropertyChanging();
					this._OperatorName = value;
					this.SendPropertyChanged("OperatorName");
					this.OnOperatorNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PreFirstBoard")]
	public partial class PreFirstBoard : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PreFirstBoardID;
		
		private bool _PSPresentAndOk;
		
		private bool _DrawingPresentAndOk;
		
		private bool _BOMPresentAndOk;
		
		private bool _BOMAndMachineJobPckMatch;
		
		private bool _OldProgramsAndDataCleared;
		
		private bool _ShimCheckOk;
		
		private int _CorrectChangeBotesChoiceID;
		
		private int _CorrectConcessionChoiceID;
		
		private int _CorrectERMNChoiceID;
		
		private bool _ReelCheckOk;
		
		private int _OperatorID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPreFirstBoardIDChanging(int value);
    partial void OnPreFirstBoardIDChanged();
    partial void OnPSPresentAndOkChanging(bool value);
    partial void OnPSPresentAndOkChanged();
    partial void OnDrawingPresentAndOkChanging(bool value);
    partial void OnDrawingPresentAndOkChanged();
    partial void OnBOMPresentAndOkChanging(bool value);
    partial void OnBOMPresentAndOkChanged();
    partial void OnBOMAndMachineJobPckMatchChanging(bool value);
    partial void OnBOMAndMachineJobPckMatchChanged();
    partial void OnOldProgramsAndDataClearedChanging(bool value);
    partial void OnOldProgramsAndDataClearedChanged();
    partial void OnShimCheckOkChanging(bool value);
    partial void OnShimCheckOkChanged();
    partial void OnCorrectChangeBotesChoiceIDChanging(int value);
    partial void OnCorrectChangeBotesChoiceIDChanged();
    partial void OnCorrectConcessionChoiceIDChanging(int value);
    partial void OnCorrectConcessionChoiceIDChanged();
    partial void OnCorrectERMNChoiceIDChanging(int value);
    partial void OnCorrectERMNChoiceIDChanged();
    partial void OnReelCheckOkChanging(bool value);
    partial void OnReelCheckOkChanged();
    partial void OnOperatorIDChanging(int value);
    partial void OnOperatorIDChanged();
    #endregion
		
		public PreFirstBoard()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PreFirstBoardID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PreFirstBoardID
		{
			get
			{
				return this._PreFirstBoardID;
			}
			set
			{
				if ((this._PreFirstBoardID != value))
				{
					this.OnPreFirstBoardIDChanging(value);
					this.SendPropertyChanging();
					this._PreFirstBoardID = value;
					this.SendPropertyChanged("PreFirstBoardID");
					this.OnPreFirstBoardIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PSPresentAndOk", DbType="Bit NOT NULL")]
		public bool PSPresentAndOk
		{
			get
			{
				return this._PSPresentAndOk;
			}
			set
			{
				if ((this._PSPresentAndOk != value))
				{
					this.OnPSPresentAndOkChanging(value);
					this.SendPropertyChanging();
					this._PSPresentAndOk = value;
					this.SendPropertyChanged("PSPresentAndOk");
					this.OnPSPresentAndOkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DrawingPresentAndOk", DbType="Bit NOT NULL")]
		public bool DrawingPresentAndOk
		{
			get
			{
				return this._DrawingPresentAndOk;
			}
			set
			{
				if ((this._DrawingPresentAndOk != value))
				{
					this.OnDrawingPresentAndOkChanging(value);
					this.SendPropertyChanging();
					this._DrawingPresentAndOk = value;
					this.SendPropertyChanged("DrawingPresentAndOk");
					this.OnDrawingPresentAndOkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BOMPresentAndOk", DbType="Bit NOT NULL")]
		public bool BOMPresentAndOk
		{
			get
			{
				return this._BOMPresentAndOk;
			}
			set
			{
				if ((this._BOMPresentAndOk != value))
				{
					this.OnBOMPresentAndOkChanging(value);
					this.SendPropertyChanging();
					this._BOMPresentAndOk = value;
					this.SendPropertyChanged("BOMPresentAndOk");
					this.OnBOMPresentAndOkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BOMAndMachineJobPckMatch", DbType="Bit NOT NULL")]
		public bool BOMAndMachineJobPckMatch
		{
			get
			{
				return this._BOMAndMachineJobPckMatch;
			}
			set
			{
				if ((this._BOMAndMachineJobPckMatch != value))
				{
					this.OnBOMAndMachineJobPckMatchChanging(value);
					this.SendPropertyChanging();
					this._BOMAndMachineJobPckMatch = value;
					this.SendPropertyChanged("BOMAndMachineJobPckMatch");
					this.OnBOMAndMachineJobPckMatchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OldProgramsAndDataCleared", DbType="Bit NOT NULL")]
		public bool OldProgramsAndDataCleared
		{
			get
			{
				return this._OldProgramsAndDataCleared;
			}
			set
			{
				if ((this._OldProgramsAndDataCleared != value))
				{
					this.OnOldProgramsAndDataClearedChanging(value);
					this.SendPropertyChanging();
					this._OldProgramsAndDataCleared = value;
					this.SendPropertyChanged("OldProgramsAndDataCleared");
					this.OnOldProgramsAndDataClearedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShimCheckOk", DbType="Bit NOT NULL")]
		public bool ShimCheckOk
		{
			get
			{
				return this._ShimCheckOk;
			}
			set
			{
				if ((this._ShimCheckOk != value))
				{
					this.OnShimCheckOkChanging(value);
					this.SendPropertyChanging();
					this._ShimCheckOk = value;
					this.SendPropertyChanged("ShimCheckOk");
					this.OnShimCheckOkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorrectChangeBotesChoiceID", DbType="Int NOT NULL")]
		public int CorrectChangeBotesChoiceID
		{
			get
			{
				return this._CorrectChangeBotesChoiceID;
			}
			set
			{
				if ((this._CorrectChangeBotesChoiceID != value))
				{
					this.OnCorrectChangeBotesChoiceIDChanging(value);
					this.SendPropertyChanging();
					this._CorrectChangeBotesChoiceID = value;
					this.SendPropertyChanged("CorrectChangeBotesChoiceID");
					this.OnCorrectChangeBotesChoiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorrectConcessionChoiceID", DbType="Int NOT NULL")]
		public int CorrectConcessionChoiceID
		{
			get
			{
				return this._CorrectConcessionChoiceID;
			}
			set
			{
				if ((this._CorrectConcessionChoiceID != value))
				{
					this.OnCorrectConcessionChoiceIDChanging(value);
					this.SendPropertyChanging();
					this._CorrectConcessionChoiceID = value;
					this.SendPropertyChanged("CorrectConcessionChoiceID");
					this.OnCorrectConcessionChoiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorrectERMNChoiceID", DbType="Int NOT NULL")]
		public int CorrectERMNChoiceID
		{
			get
			{
				return this._CorrectERMNChoiceID;
			}
			set
			{
				if ((this._CorrectERMNChoiceID != value))
				{
					this.OnCorrectERMNChoiceIDChanging(value);
					this.SendPropertyChanging();
					this._CorrectERMNChoiceID = value;
					this.SendPropertyChanged("CorrectERMNChoiceID");
					this.OnCorrectERMNChoiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReelCheckOk", DbType="Bit NOT NULL")]
		public bool ReelCheckOk
		{
			get
			{
				return this._ReelCheckOk;
			}
			set
			{
				if ((this._ReelCheckOk != value))
				{
					this.OnReelCheckOkChanging(value);
					this.SendPropertyChanging();
					this._ReelCheckOk = value;
					this.SendPropertyChanged("ReelCheckOk");
					this.OnReelCheckOkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperatorID", DbType="Int NOT NULL")]
		public int OperatorID
		{
			get
			{
				return this._OperatorID;
			}
			set
			{
				if ((this._OperatorID != value))
				{
					this.OnOperatorIDChanging(value);
					this.SendPropertyChanging();
					this._OperatorID = value;
					this.SendPropertyChanged("OperatorID");
					this.OnOperatorIDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591