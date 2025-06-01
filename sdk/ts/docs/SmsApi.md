# SmsApi

All URIs are relative to *https://api.ubill.dev/v1*

|Method | HTTP request | Description|
|------------- | ------------- | -------------|
|[**getBalance**](#getbalance) | **GET** /sms/balance | Get SMS Balance|
|[**getBrandNames**](#getbrandnames) | **GET** /sms/brandNames | Get All BrandNames|
|[**getDeliveryReport**](#getdeliveryreport) | **GET** /sms/report/{smsID} | Get Delivery Report|
|[**sendSMS**](#sendsms) | **POST** /sms/send | Send SMS|

# **getBalance**
> SMSBalanceResponse getBalance()


### Example

```typescript
import {
    SmsApi,
    Configuration
} from 'abgeo/ubill-sdk';

const configuration = new Configuration();
const apiInstance = new SmsApi(configuration);

let body: any; // (optional)

const { status, data } = await apiInstance.getBalance(
    body
);
```

### Parameters

|Name | Type | Description  | Notes|
|------------- | ------------- | ------------- | -------------|
| **body** | **any**|  | |


### Return type

**SMSBalanceResponse**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
|**200** | successful operation |  -  |
|**401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getBrandNames**
> BrandNamesResponse getBrandNames()


### Example

```typescript
import {
    SmsApi,
    Configuration
} from 'abgeo/ubill-sdk';

const configuration = new Configuration();
const apiInstance = new SmsApi(configuration);

let body: any; // (optional)

const { status, data } = await apiInstance.getBrandNames(
    body
);
```

### Parameters

|Name | Type | Description  | Notes|
|------------- | ------------- | ------------- | -------------|
| **body** | **any**|  | |


### Return type

**BrandNamesResponse**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
|**200** | successful operation |  -  |
|**401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getDeliveryReport**
> DeliveryReportResponse getDeliveryReport()


### Example

```typescript
import {
    SmsApi,
    Configuration
} from 'abgeo/ubill-sdk';

const configuration = new Configuration();
const apiInstance = new SmsApi(configuration);

let smsID: number; //ID of SMS to get report for (default to undefined)
let body: any; // (optional)

const { status, data } = await apiInstance.getDeliveryReport(
    smsID,
    body
);
```

### Parameters

|Name | Type | Description  | Notes|
|------------- | ------------- | ------------- | -------------|
| **body** | **any**|  | |
| **smsID** | [**number**] | ID of SMS to get report for | defaults to undefined|


### Return type

**DeliveryReportResponse**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
|**200** | successful operation |  -  |
|**401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sendSMS**
> SendSMSResponse sendSMS()


### Example

```typescript
import {
    SmsApi,
    Configuration,
    SMSPayload
} from 'abgeo/ubill-sdk';

const configuration = new Configuration();
const apiInstance = new SmsApi(configuration);

let sMSPayload: SMSPayload; //Pet object that needs to be added to the store (optional)

const { status, data } = await apiInstance.sendSMS(
    sMSPayload
);
```

### Parameters

|Name | Type | Description  | Notes|
|------------- | ------------- | ------------- | -------------|
| **sMSPayload** | **SMSPayload**| Pet object that needs to be added to the store | |


### Return type

**SendSMSResponse**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
|**200** | successful operation |  -  |
|**401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

