﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetOpenId.Consumer {
	public interface INonceStore {
		byte[] SecretSigningKey { get; }

		void StoreNonce(Nonce nonce);
		bool ContainsNonce(Nonce nonce);
		void ClearExpiredNonces();
	}
}
