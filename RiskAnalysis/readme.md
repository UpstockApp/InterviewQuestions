## Risk Analysis

Our support team wants some help to identify risky signups and buyers. We sometimes get customers that will connect to several suppliers in short succession and place tons of orders with them - with no intention of paying.

We want to help make it easy to identify these problematic customers.

If an action is considered risky in context, we should send a notification to support. We don't want to overwhelm them with notifications though, only on unique risky behavior.

You don't need to worry about the specific implementation details for sending a notification (like slack, email, etc).

Some rules that have been suggested:

- 5 new supplier connections requested by the buyer
- A buyer is rejected or disconnected multiple times
- 3 1st time orders with a supplier
