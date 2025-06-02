# SmsApi

All URIs are relative to *https://api.ubill.dev/v1*

|Method | HTTP request | Description|
|------------- | ------------- | -------------|
|[**createBrandName**](#createbrandname) | **POST** /sms/brandNameCreate | Create Brand Name|
|[**getBalance**](#getbalance) | **GET** /sms/balance | Get SMS Balance|
|[**getBrandNames**](#getbrandnames) | **GET** /sms/brandNames | Get All Brand Names|
|[**getDeliveryReport**](#getdeliveryreport) | **GET** /sms/report/{smsID} | Get Delivery Report|
|[**sendSMS**](#sendsms) | **POST** /sms/send | Send SMS|

# **createBrandName**
> CreateBrandNameResponse createBrandName()


### Example

```typescript
import {
    SmsApi,
    Configuration,
    CreateBrandNamePayload
} from 'abgeo/ubill-sdk';

const configuration = new Configuration();
const apiInstance = new SmsApi(configuration);

let createBrandNamePayload: CreateBrandNamePayload; //Brand Name payload to create (optional)

const { status, data } = await apiInstance.createBrandName(
    createBrandNamePayload
);
```

### Parameters

|Name | Type | Description  | Notes|
|------------- | ------------- | ------------- | -------------|
| **createBrandNamePayload** | **CreateBrandNamePayload**| Brand Name payload to create | |


### Return type

**CreateBrandNameResponse**

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

const { status, data } = await apiInstance.getBalance();
```

### Parameters
This endpoint does not have any parameters.


### Return type

**SMSBalanceResponse**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
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

const { status, data } = await apiInstance.getBrandNames();
```

### Parameters
This endpoint does not have any parameters.


### Return type

**BrandNamesResponse**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
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

let smsID: number; //Unique identifier of the SMS (default to undefined)

const { status, data } = await apiInstance.getDeliveryReport(
    smsID
);
```

### Parameters

|Name | Type | Description  | Notes|
|------------- | ------------- | ------------- | -------------|
| **smsID** | [**number**] | Unique identifier of the SMS | defaults to undefined|


### Return type

**DeliveryReportResponse**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
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

let sMSPayload: SMSPayload; //SMS payload for sending messages (optional)

const { status, data } = await apiInstance.sendSMS(
    sMSPayload
);
```

### Parameters

|Name | Type | Description  | Notes|
|------------- | ------------- | ------------- | -------------|
| **sMSPayload** | **SMSPayload**| SMS payload for sending messages | |


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

