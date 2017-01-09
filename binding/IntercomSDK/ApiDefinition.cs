using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace IntercomSDK
{
	[BaseType(typeof(NSObject))]
	interface Intercom
	{
		[Static]
		[Export("setApiKey:forAppId:")]
		void SetApiKey(string apiKey, string appId);

		[Static]
		[Export("setHMAC:data:")]
		void SetHMAC(string hmac, string data);

		[Static]
		[Export("registerUnidentifiedUser")]
		void RegisterUnidentifiedUser();

		[Static]
		[Export("registerUserWithUserId:email:")]
		void RegisterUserWithUserId(string userId, string email);

		[Static]
		[Export("registerUserWithUserId:")]
		void RegisterUserWithUserId(string userId);

		[Static]
		[Export("registerUserWithEmail:")]
		void RegisterUserWithEmail(string email);

		[Static]
		[Export("reset")]
		void Reset();

		[Static]
		[Export("updateUserWithAttributes:")]
		void UpdateUserWithAttributes(NSDictionary attributes);

		[Static]
		[Export("logEventWithName:")]
		void LogEventWithName(string name);

		[Static]
		[Export("logEventWithName:metaData:")]
		void LogEventWithName(string name, NSDictionary metaData);

		[Static]
		[Export("presentMessenger")]
		void PresentMessenger();

		[Static]
		[Export("presentMessageComposer")]
		void PresentMessageComposer();

		[Static]
		[Export("presentMessageComposerWithInitialMessage:")]
		void PresentMessageComposerWithInitialMessage(string message);

		[Static]
		[Export("presentConversationList")]
		void PresentConversationList();

		[Static]
		[Export("setDeviceToken:")]
		void SetDeviceToken(NSData deviceToken);

		[Static]
		[Export("setBottomPadding:")]
		void SetBottomPadding(nfloat bottomPadding);

		[Static]
		[Export("setInAppMessagesVisible:")]
		void SetInAppMessagesVisible(bool visible);

		[Static]
		[Export("setLauncherVisible:")]
		void SetLauncherVisible(bool visible);

		[Static]
		[Export("hideMessenger")]
		void HideMessenger();

		[Static]
		[Export("unreadConversationCount")]
		int UnreadConversationCount { get; }

		[Static]
		[Export("enableLogging")]
		void EnableLogging();

		[Static]
		[Export("setNeedsStatusBarAppearanceUpdate")]
		void SetNeedsStatusBarAppearanceUpdate();
	}

	[Static]
	partial interface Constants
	{
		[Field("IntercomUnreadConversationCountDidChangeNotification", "__Internal")]
		NSString IntercomUnreadConversationCountDidChangeNotification { get; }

		[Field("IntercomWindowWillShowNotification", "__Internal")]
		NSString IntercomWindowWillShowNotification { get; }

		[Field("IntercomWindowDidShowNotification", "__Internal")]
		NSString IntercomWindowDidShowNotification { get; }

		[Field("IntercomWindowWillHideNotification", "__Internal")]
		NSString IntercomWindowWillHideNotification { get; }

		[Field("IntercomWindowDidHideNotification", "__Internal")]
		NSString IntercomWindowDidHideNotification { get; }

		[Field("IntercomDidStartNewConversationNotification", "__Internal")]
		NSString IntercomDidStartNewConversationNotification { get; }
	}
}