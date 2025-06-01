import {Configuration} from "../configuration";
import {SmsApi} from "../api/sms-api";

// Basic configuration with API key
const config = new Configuration({
    apiKey: "your-api-key-here",
});

const smsApi = new SmsApi(config);

// Get account balance
smsApi.getBalance()
    .then(balance => {
        console.log("Account balance:", balance.data);
    })
    .catch(error => {
        console.error("Error fetching balance:", error);
    });
