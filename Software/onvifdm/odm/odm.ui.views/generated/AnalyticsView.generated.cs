﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reactive.Disposables;
using System.Windows.Input;
using odm.infra;
namespace odm.ui.activities {
	using global::System.Xml;
	using global::System.Xml.Schema;
	using global::onvif.services;
	
	public partial class AnalyticsView{
		
		#region Model definition
		
		public class Model{
			
			public Model(
				XmlSchemaSet moduleSchemes, ConfigDescription[] moduleTypes, Config[] modules, XmlSchemaSet ruleSchemes, ConfigDescription[] ruleTypes, Config[] rules
			){
				
				this.moduleSchemes = moduleSchemes;
				this.moduleTypes = moduleTypes;
				this.modules = modules;
				this.ruleSchemes = ruleSchemes;
				this.ruleTypes = ruleTypes;
				this.rules = rules;
			}
			private Model(){
			}
			

			public static Model Create(
				XmlSchemaSet moduleSchemes,
				ConfigDescription[] moduleTypes,
				Config[] modules,
				XmlSchemaSet ruleSchemes,
				ConfigDescription[] ruleTypes,
				Config[] rules
			){
				var _this = new Model();
				
				_this.moduleSchemes = moduleSchemes;
				_this.moduleTypes = moduleTypes;
				_this.modules = modules;
				_this.ruleSchemes = ruleSchemes;
				_this.ruleTypes = ruleTypes;
				_this.rules = rules;
				return _this;
			}
		
			public XmlSchemaSet moduleSchemes{get;private set;}
			public ConfigDescription[] moduleTypes{get;private set;}
			public Config[] modules{get;private set;}
			public XmlSchemaSet ruleSchemes{get;private set;}
			public ConfigDescription[] ruleTypes{get;private set;}
			public Config[] rules{get;private set;}
		}
			
		#endregion
	
		#region Result definition
		public abstract class Result{
			private Result() { }
			
			public abstract T Handle<T>(
				
				Func<T> createModule,
				Func<string,T> deleteModule,
				Func<Config,T> configureModule,
				Func<T> createRule,
				Func<string,T> deleteRule,
				Func<Config,T> configureRule,
				Func<T> close
			);
	
			public bool IsCreateModule(){
				return AsCreateModule() != null;
			}
			public virtual CreateModule AsCreateModule(){ return null; }
			public class CreateModule : Result {
				public CreateModule(){
					
				}
				
				public override CreateModule AsCreateModule(){ return this; }
				
				public override T Handle<T>(
				
					Func<T> createModule,
					Func<string,T> deleteModule,
					Func<Config,T> configureModule,
					Func<T> createRule,
					Func<string,T> deleteRule,
					Func<Config,T> configureRule,
					Func<T> close
				){
					return createModule(
						
					);
				}
	
			}
			
			public bool IsDeleteModule(){
				return AsDeleteModule() != null;
			}
			public virtual DeleteModule AsDeleteModule(){ return null; }
			public class DeleteModule : Result {
				public DeleteModule(string name){
					
					this.name = name;
					
				}
				public string name{ get; set; }
				public override DeleteModule AsDeleteModule(){ return this; }
				
				public override T Handle<T>(
				
					Func<T> createModule,
					Func<string,T> deleteModule,
					Func<Config,T> configureModule,
					Func<T> createRule,
					Func<string,T> deleteRule,
					Func<Config,T> configureRule,
					Func<T> close
				){
					return deleteModule(
						name
					);
				}
	
			}
			
			public bool IsConfigureModule(){
				return AsConfigureModule() != null;
			}
			public virtual ConfigureModule AsConfigureModule(){ return null; }
			public class ConfigureModule : Result {
				public ConfigureModule(Config module){
					
					this.module = module;
					
				}
				public Config module{ get; set; }
				public override ConfigureModule AsConfigureModule(){ return this; }
				
				public override T Handle<T>(
				
					Func<T> createModule,
					Func<string,T> deleteModule,
					Func<Config,T> configureModule,
					Func<T> createRule,
					Func<string,T> deleteRule,
					Func<Config,T> configureRule,
					Func<T> close
				){
					return configureModule(
						module
					);
				}
	
			}
			
			public bool IsCreateRule(){
				return AsCreateRule() != null;
			}
			public virtual CreateRule AsCreateRule(){ return null; }
			public class CreateRule : Result {
				public CreateRule(){
					
				}
				
				public override CreateRule AsCreateRule(){ return this; }
				
				public override T Handle<T>(
				
					Func<T> createModule,
					Func<string,T> deleteModule,
					Func<Config,T> configureModule,
					Func<T> createRule,
					Func<string,T> deleteRule,
					Func<Config,T> configureRule,
					Func<T> close
				){
					return createRule(
						
					);
				}
	
			}
			
			public bool IsDeleteRule(){
				return AsDeleteRule() != null;
			}
			public virtual DeleteRule AsDeleteRule(){ return null; }
			public class DeleteRule : Result {
				public DeleteRule(string name){
					
					this.name = name;
					
				}
				public string name{ get; set; }
				public override DeleteRule AsDeleteRule(){ return this; }
				
				public override T Handle<T>(
				
					Func<T> createModule,
					Func<string,T> deleteModule,
					Func<Config,T> configureModule,
					Func<T> createRule,
					Func<string,T> deleteRule,
					Func<Config,T> configureRule,
					Func<T> close
				){
					return deleteRule(
						name
					);
				}
	
			}
			
			public bool IsConfigureRule(){
				return AsConfigureRule() != null;
			}
			public virtual ConfigureRule AsConfigureRule(){ return null; }
			public class ConfigureRule : Result {
				public ConfigureRule(Config rule){
					
					this.rule = rule;
					
				}
				public Config rule{ get; set; }
				public override ConfigureRule AsConfigureRule(){ return this; }
				
				public override T Handle<T>(
				
					Func<T> createModule,
					Func<string,T> deleteModule,
					Func<Config,T> configureModule,
					Func<T> createRule,
					Func<string,T> deleteRule,
					Func<Config,T> configureRule,
					Func<T> close
				){
					return configureRule(
						rule
					);
				}
	
			}
			
			public bool IsClose(){
				return AsClose() != null;
			}
			public virtual Close AsClose(){ return null; }
			public class Close : Result {
				public Close(){
					
				}
				
				public override Close AsClose(){ return this; }
				
				public override T Handle<T>(
				
					Func<T> createModule,
					Func<string,T> deleteModule,
					Func<Config,T> configureModule,
					Func<T> createRule,
					Func<string,T> deleteRule,
					Func<Config,T> configureRule,
					Func<T> close
				){
					return close(
						
					);
				}
	
			}
			
		}
		#endregion

		public ICommand CreateModuleCommand{ get; private set; }
		public ICommand DeleteModuleCommand{ get; private set; }
		public ICommand ConfigureModuleCommand{ get; private set; }
		public ICommand CreateRuleCommand{ get; private set; }
		public ICommand DeleteRuleCommand{ get; private set; }
		public ICommand ConfigureRuleCommand{ get; private set; }
		public ICommand CloseCommand{ get; private set; }
		
		IActivityContext<Result> activityContext = null;
		SingleAssignmentDisposable activityCancellationSubscription = new SingleAssignmentDisposable();
		bool activityCompleted = false;
		//activity has been completed
		event Action OnCompleted = null;
		//activity has been failed
		event Action<Exception> OnError = null;
		//activity has been completed successfully
		event Action<Result> OnSuccess = null;
		//activity has been canceled
		event Action OnCancelled = null;
		
		public AnalyticsView(Model model, IActivityContext<Result> activityContext) {
			this.activityContext = activityContext;
			if(activityContext!=null){
				activityCancellationSubscription.Disposable = 
					activityContext.RegisterCancellationCallback(() => {
						EnsureAccess(() => {
							CompleteWith(() => {
								if(OnCancelled!=null){
									OnCancelled();
								}
							});
						});
					});
			}
			Init(model);
		}

		
		public void EnsureAccess(Action action){
			if(!CheckAccess()){
				Dispatcher.Invoke(action);
			}else{
				action();
			}
		}

		public void CompleteWith(Action cont){
			if(!activityCompleted){
				activityCompleted = true;
				cont();
				if(OnCompleted!=null){
					OnCompleted();
				}
				activityCancellationSubscription.Dispose();
			}
		}
		public void Success(Result result) {
			CompleteWith(() => {
				if(activityContext!=null){
					activityContext.Success(result);
				}
				if(OnSuccess!=null){
					OnSuccess(result);
				}
			});
		}
		public void Error(Exception error) {
			CompleteWith(() => {
				if(activityContext!=null){
					activityContext.Error(error);
				}
				if(OnError!=null){
					OnError(error);
				}
			});
		}
		public void Cancel() {
			CompleteWith(() => {
				if(activityContext!=null){
					activityContext.Cancel();
				}
				if(OnCancelled!=null){
					OnCancelled();
				}
			});
		}
		public void Success(Func<Result> resultFactory) {
			CompleteWith(() => {
				var result = resultFactory();
				if(activityContext!=null){
					activityContext.Success(result);
				}
				if(OnSuccess!=null){
					OnSuccess(result);
				}
			});
		}
		public void Error(Func<Exception> errorFactory) {
			CompleteWith(() => {
				var error = errorFactory();
				if(activityContext!=null){
					activityContext.Error(error);
				}
				if(OnError!=null){
					OnError(error);
				}
			});
		}
		public void Cancel(Action action) {
			CompleteWith(() => {
				action();
				if(activityContext!=null){
					activityContext.Cancel();
				}
				if(OnCancelled!=null){
					OnCancelled();
				}
			});
		}
		
	}
}
