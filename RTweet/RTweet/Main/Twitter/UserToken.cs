﻿using CoreTweet;

namespace RTweet.Main.Twitter {
	/// <summary>
	/// ユーザーのアクセストークンを表す構造体
	/// </summary>
	internal class UserToken {

		/// <summary>
		/// ユーザーの数値ID
		/// </summary>
		public string Id { get; private set; }

		/// <summary>
		/// ユーザーの名前(@ID)
		/// </summary>
		public string Screen_name => Tokens.ScreenName;

		

		/// <summary>
		/// アクセストークン
		/// </summary>
		public string AccessToken { get; private set; }

		/// <summary>
		/// シークレットアクセストークン
		/// </summary>
		public string TokenSecret { get; private set; }


		private Tokens _tokens;
		/// <summary>
		/// トークンオブジェクト
		/// </summary>
		public Tokens Tokens => _tokens ?? (_tokens = Tokens.Create(TwitterSystem.ApiKey, TwitterSystem.ApiSecret, AccessToken, TokenSecret));


		/// <summary>
		/// 構造体の生成
		/// </summary>
		/// <param name="id">ユーザーID</param>
		/// <param name="accessToken">アクセストークン</param>
		/// <param name="tokenSecret">シークレットアクセストークン</param>
		public UserToken(string id, string accessToken, string tokenSecret, Tokens tokens = null) {
			Id = id;
			AccessToken = accessToken;
			TokenSecret = tokenSecret;
			_tokens = tokens;
		}



	}
}