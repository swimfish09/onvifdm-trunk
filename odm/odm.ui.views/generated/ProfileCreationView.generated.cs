
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
	using global::onvif.services;
	
	public partial class ProfileCreationView{
		
		#region Model definition
		
		public interface IModelAccessor{
			string profName{get;set;}
			string profToken{get;set;}
			VideoSourceConfiguration videoSrcCfg{get;set;}
			AudioSourceConfiguration audioSrcCfg{get;set;}
			bool isVideoSrcCfgEnabled{get;set;}
			bool isAudioSrcCfgEnabled{get;set;}
			
		}
		public class Model: IModelAccessor, INotifyPropertyChanged{
			
			public Model(
				VideoSourceConfiguration[] videoSrcCfgs, AudioSourceConfiguration[] audioSrcCfgs
			){
				
				this.videoSrcCfgs = videoSrcCfgs;
				this.audioSrcCfgs = audioSrcCfgs;
			}
			private Model(){
			}
			

			public static Model Create(
				string profName,
				string profToken,
				VideoSourceConfiguration videoSrcCfg,
				AudioSourceConfiguration audioSrcCfg,
				bool isVideoSrcCfgEnabled,
				bool isAudioSrcCfgEnabled,
				VideoSourceConfiguration[] videoSrcCfgs,
				AudioSourceConfiguration[] audioSrcCfgs
			){
				var _this = new Model();
				
				_this.videoSrcCfgs = videoSrcCfgs;
				_this.audioSrcCfgs = audioSrcCfgs;
				_this.origin.profName = profName;
				_this.origin.profToken = profToken;
				_this.origin.videoSrcCfg = videoSrcCfg;
				_this.origin.audioSrcCfg = audioSrcCfg;
				_this.origin.isVideoSrcCfgEnabled = isVideoSrcCfgEnabled;
				_this.origin.isAudioSrcCfgEnabled = isAudioSrcCfgEnabled;
				_this.RevertChanges();
				
				return _this;
			}
		
				private SimpleChangeTrackable<string> m_profName;
				private SimpleChangeTrackable<string> m_profToken;
				private SimpleChangeTrackable<VideoSourceConfiguration> m_videoSrcCfg;
				private SimpleChangeTrackable<AudioSourceConfiguration> m_audioSrcCfg;
				private SimpleChangeTrackable<bool> m_isVideoSrcCfgEnabled;
				private SimpleChangeTrackable<bool> m_isAudioSrcCfgEnabled;
				public VideoSourceConfiguration[] videoSrcCfgs{get;private set;}
				public AudioSourceConfiguration[] audioSrcCfgs{get;private set;}

			private class OriginAccessor: IModelAccessor {
				private Model m_model;
				public OriginAccessor(Model model) {
					m_model = model;
				}
				string IModelAccessor.profName {
					get {return m_model.m_profName.origin;}
					set {m_model.m_profName.origin = value;}
				}
				string IModelAccessor.profToken {
					get {return m_model.m_profToken.origin;}
					set {m_model.m_profToken.origin = value;}
				}
				VideoSourceConfiguration IModelAccessor.videoSrcCfg {
					get {return m_model.m_videoSrcCfg.origin;}
					set {m_model.m_videoSrcCfg.origin = value;}
				}
				AudioSourceConfiguration IModelAccessor.audioSrcCfg {
					get {return m_model.m_audioSrcCfg.origin;}
					set {m_model.m_audioSrcCfg.origin = value;}
				}
				bool IModelAccessor.isVideoSrcCfgEnabled {
					get {return m_model.m_isVideoSrcCfgEnabled.origin;}
					set {m_model.m_isVideoSrcCfgEnabled.origin = value;}
				}
				bool IModelAccessor.isAudioSrcCfgEnabled {
					get {return m_model.m_isAudioSrcCfgEnabled.origin;}
					set {m_model.m_isAudioSrcCfgEnabled.origin = value;}
				}
				
			}
			public event PropertyChangedEventHandler PropertyChanged;
			private void NotifyPropertyChanged(string propertyName){
				var prop_changed = this.PropertyChanged;
				if (prop_changed != null) {
					prop_changed(this, new PropertyChangedEventArgs(propertyName));
				}
			}
			
			public string profName  {
				get {return m_profName.current;}
				set {
					if(m_profName.current != value) {
						m_profName.current = value;
						NotifyPropertyChanged("profName");
					}
				}
			}
			
			public string profToken  {
				get {return m_profToken.current;}
				set {
					if(m_profToken.current != value) {
						m_profToken.current = value;
						NotifyPropertyChanged("profToken");
					}
				}
			}
			
			public VideoSourceConfiguration videoSrcCfg  {
				get {return m_videoSrcCfg.current;}
				set {
					if(m_videoSrcCfg.current != value) {
						m_videoSrcCfg.current = value;
						NotifyPropertyChanged("videoSrcCfg");
					}
				}
			}
			
			public AudioSourceConfiguration audioSrcCfg  {
				get {return m_audioSrcCfg.current;}
				set {
					if(m_audioSrcCfg.current != value) {
						m_audioSrcCfg.current = value;
						NotifyPropertyChanged("audioSrcCfg");
					}
				}
			}
			
			public bool isVideoSrcCfgEnabled  {
				get {return m_isVideoSrcCfgEnabled.current;}
				set {
					if(m_isVideoSrcCfgEnabled.current != value) {
						m_isVideoSrcCfgEnabled.current = value;
						NotifyPropertyChanged("isVideoSrcCfgEnabled");
					}
				}
			}
			
			public bool isAudioSrcCfgEnabled  {
				get {return m_isAudioSrcCfgEnabled.current;}
				set {
					if(m_isAudioSrcCfgEnabled.current != value) {
						m_isAudioSrcCfgEnabled.current = value;
						NotifyPropertyChanged("isAudioSrcCfgEnabled");
					}
				}
			}
			
			public void AcceptChanges() {
				m_profName.AcceptChanges();
				m_profToken.AcceptChanges();
				m_videoSrcCfg.AcceptChanges();
				m_audioSrcCfg.AcceptChanges();
				m_isVideoSrcCfgEnabled.AcceptChanges();
				m_isAudioSrcCfgEnabled.AcceptChanges();
				
			}

			public void RevertChanges() {
				this.current.profName= this.origin.profName;
				this.current.profToken= this.origin.profToken;
				this.current.videoSrcCfg= this.origin.videoSrcCfg;
				this.current.audioSrcCfg= this.origin.audioSrcCfg;
				this.current.isVideoSrcCfgEnabled= this.origin.isVideoSrcCfgEnabled;
				this.current.isAudioSrcCfgEnabled= this.origin.isAudioSrcCfgEnabled;
				
			}

			public bool isModified {
				get {
					if(m_profName.isModified)return true;
					if(m_profToken.isModified)return true;
					if(m_videoSrcCfg.isModified)return true;
					if(m_audioSrcCfg.isModified)return true;
					if(m_isVideoSrcCfgEnabled.isModified)return true;
					if(m_isAudioSrcCfgEnabled.isModified)return true;
					
					return false;
				}
			}

			public IModelAccessor current {
				get {return this;}
				
			}

			public IModelAccessor origin {
				get {return new OriginAccessor(this);}
				
			}
		}
			
		#endregion
	
		#region Result definition
		public abstract class Result{
			private Result() { }
			
			public abstract T Handle<T>(
				
				Func<Model,T> finish,
				Func<T> abort,
				Func<Model,T> configure,
				Func<Model,T> selectVideoSrcCfg,
				Func<Model,T> selectAudioSrcCfg
			);
	
			public bool IsFinish(){
				return AsFinish() != null;
			}
			public virtual Finish AsFinish(){ return null; }
			public class Finish : Result {
				public Finish(Model model){
					
					this.model = model;
					
				}
				public Model model{ get; set; }
				public override Finish AsFinish(){ return this; }
				
				public override T Handle<T>(
				
					Func<Model,T> finish,
					Func<T> abort,
					Func<Model,T> configure,
					Func<Model,T> selectVideoSrcCfg,
					Func<Model,T> selectAudioSrcCfg
				){
					return finish(
						model
					);
				}
	
			}
			
			public bool IsAbort(){
				return AsAbort() != null;
			}
			public virtual Abort AsAbort(){ return null; }
			public class Abort : Result {
				public Abort(){
					
				}
				
				public override Abort AsAbort(){ return this; }
				
				public override T Handle<T>(
				
					Func<Model,T> finish,
					Func<T> abort,
					Func<Model,T> configure,
					Func<Model,T> selectVideoSrcCfg,
					Func<Model,T> selectAudioSrcCfg
				){
					return abort(
						
					);
				}
	
			}
			
			public bool IsConfigure(){
				return AsConfigure() != null;
			}
			public virtual Configure AsConfigure(){ return null; }
			public class Configure : Result {
				public Configure(Model model){
					
					this.model = model;
					
				}
				public Model model{ get; set; }
				public override Configure AsConfigure(){ return this; }
				
				public override T Handle<T>(
				
					Func<Model,T> finish,
					Func<T> abort,
					Func<Model,T> configure,
					Func<Model,T> selectVideoSrcCfg,
					Func<Model,T> selectAudioSrcCfg
				){
					return configure(
						model
					);
				}
	
			}
			
			public bool IsSelectVideoSrcCfg(){
				return AsSelectVideoSrcCfg() != null;
			}
			public virtual SelectVideoSrcCfg AsSelectVideoSrcCfg(){ return null; }
			public class SelectVideoSrcCfg : Result {
				public SelectVideoSrcCfg(Model model){
					
					this.model = model;
					
				}
				public Model model{ get; set; }
				public override SelectVideoSrcCfg AsSelectVideoSrcCfg(){ return this; }
				
				public override T Handle<T>(
				
					Func<Model,T> finish,
					Func<T> abort,
					Func<Model,T> configure,
					Func<Model,T> selectVideoSrcCfg,
					Func<Model,T> selectAudioSrcCfg
				){
					return selectVideoSrcCfg(
						model
					);
				}
	
			}
			
			public bool IsSelectAudioSrcCfg(){
				return AsSelectAudioSrcCfg() != null;
			}
			public virtual SelectAudioSrcCfg AsSelectAudioSrcCfg(){ return null; }
			public class SelectAudioSrcCfg : Result {
				public SelectAudioSrcCfg(Model model){
					
					this.model = model;
					
				}
				public Model model{ get; set; }
				public override SelectAudioSrcCfg AsSelectAudioSrcCfg(){ return this; }
				
				public override T Handle<T>(
				
					Func<Model,T> finish,
					Func<T> abort,
					Func<Model,T> configure,
					Func<Model,T> selectVideoSrcCfg,
					Func<Model,T> selectAudioSrcCfg
				){
					return selectAudioSrcCfg(
						model
					);
				}
	
			}
			
		}
		#endregion

		public ICommand FinishCommand{ get; private set; }
		public ICommand AbortCommand{ get; private set; }
		public ICommand ConfigureCommand{ get; private set; }
		public ICommand SelectVideoSrcCfgCommand{ get; private set; }
		public ICommand SelectAudioSrcCfgCommand{ get; private set; }
		
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
		
		public ProfileCreationView(Model model, IActivityContext<Result> activityContext) {
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
