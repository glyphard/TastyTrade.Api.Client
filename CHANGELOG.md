# Changelog

All notable changes to **TastyTrade.Api.Client** are documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.7] - 2026-06-05

### Added

- **`CancellationToken` support across the public API.** Every facade method on
  `TastyTradeClient` that performs network I/O now accepts an optional trailing
  `CancellationToken cancellationToken = default` parameter — request/response endpoints
  (market data, option chains, instruments, accounts, positions, transactions, watchlists,
  orders) as well as the authentication paths (`AuthenticateOAuth`, `Authenticate`,
  `RefreshAccessTokenAsync`).
- The token is forwarded to the underlying `HttpClient` call **and** to every
  facade-internal `await`: the automatic 401-retry, the `GetTransactions` pagination loop,
  and the OAuth token-refresh semaphore/refresh request. Cancellation therefore tears the
  whole operation down instead of leaving an orphaned in-flight request.
- Per-method unit tests verifying that an already-cancelled token surfaces an
  `OperationCanceledException` (or its derived `TaskCanceledException`) for every facade
  method.

### Changed

- README gains a **Cancellation** section with a usage example.

### Motivation

Before this release, downstream consumers could not honour cancellation on TastyTrade calls
because the facade swallowed the token that the HTTP layer already supported. In
SAMPro.Trader this combined with a Polly pessimistic-timeout + bulkhead policy to wedge the
market-data warm-up loop: the timeout returned to the caller after 10s but the underlying
request kept running, holding its bulkhead slot until all slots were exhausted by orphans
and new calls queued indefinitely. A production incident saw an option-chain warm-up hang
for 37+ minutes with hundreds of retry failures, resolved only by a process restart.
Threading the token end-to-end closes that failure class.

### Compatibility

- Source-compatible: existing callers that omit the new argument continue to compile and
  behave exactly as before (the parameter defaults to `CancellationToken.None`).
- This is a metadata-level signature change, so callers binding exact 1.0.6 method
  signatures via reflection would need to recompile; normal callers recompiling against
  1.0.7 are unaffected.
- Streaming subscriptions (`StreamingApiBaseUrl` / WebSocket) are intentionally out of scope
  for this release and will be addressed separately.

## [1.0.6]

- Baseline release prior to cancellation support. See git history for earlier changes.
