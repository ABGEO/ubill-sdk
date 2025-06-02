# Dev.ABGEO.UBill.SDK.Api.SmsApi

All URIs are relative to *https://api.ubill.dev/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBrandName**](SmsApi.md#createbrandname) | **POST** /sms/brandNameCreate | Create Brand Name |
| [**GetBalance**](SmsApi.md#getbalance) | **GET** /sms/balance | Get SMS Balance |
| [**GetBrandNames**](SmsApi.md#getbrandnames) | **GET** /sms/brandNames | Get All Brand Names |
| [**GetDeliveryReport**](SmsApi.md#getdeliveryreport) | **GET** /sms/report/{smsID} | Get Delivery Report |
| [**SendSMS**](SmsApi.md#sendsms) | **POST** /sms/send | Send SMS |

<a id="createbrandname"></a>
# **CreateBrandName**
> CreateBrandNameResponse CreateBrandName (CreateBrandNamePayload createBrandNamePayload = null)

Create Brand Name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dev.ABGEO.UBill.SDK.Api;
using Dev.ABGEO.UBill.SDK.Client;
using Dev.ABGEO.UBill.SDK.Model;

namespace Example
{
    public class CreateBrandNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ubill.dev/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SmsApi(config);
            var createBrandNamePayload = new CreateBrandNamePayload(); // CreateBrandNamePayload | Brand Name payload to create (optional) 

            try
            {
                // Create Brand Name
                CreateBrandNameResponse result = apiInstance.CreateBrandName(createBrandNamePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsApi.CreateBrandName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBrandNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Brand Name
    ApiResponse<CreateBrandNameResponse> response = apiInstance.CreateBrandNameWithHttpInfo(createBrandNamePayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsApi.CreateBrandNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createBrandNamePayload** | [**CreateBrandNamePayload**](CreateBrandNamePayload.md) | Brand Name payload to create | [optional]  |

### Return type

[**CreateBrandNameResponse**](CreateBrandNameResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbalance"></a>
# **GetBalance**
> SMSBalanceResponse GetBalance ()

Get SMS Balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dev.ABGEO.UBill.SDK.Api;
using Dev.ABGEO.UBill.SDK.Client;
using Dev.ABGEO.UBill.SDK.Model;

namespace Example
{
    public class GetBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ubill.dev/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SmsApi(config);

            try
            {
                // Get SMS Balance
                SMSBalanceResponse result = apiInstance.GetBalance();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsApi.GetBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SMS Balance
    ApiResponse<SMSBalanceResponse> response = apiInstance.GetBalanceWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsApi.GetBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SMSBalanceResponse**](SMSBalanceResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbrandnames"></a>
# **GetBrandNames**
> BrandNamesResponse GetBrandNames ()

Get All Brand Names

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dev.ABGEO.UBill.SDK.Api;
using Dev.ABGEO.UBill.SDK.Client;
using Dev.ABGEO.UBill.SDK.Model;

namespace Example
{
    public class GetBrandNamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ubill.dev/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SmsApi(config);

            try
            {
                // Get All Brand Names
                BrandNamesResponse result = apiInstance.GetBrandNames();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsApi.GetBrandNames: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBrandNamesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All Brand Names
    ApiResponse<BrandNamesResponse> response = apiInstance.GetBrandNamesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsApi.GetBrandNamesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**BrandNamesResponse**](BrandNamesResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdeliveryreport"></a>
# **GetDeliveryReport**
> DeliveryReportResponse GetDeliveryReport (long smsID)

Get Delivery Report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dev.ABGEO.UBill.SDK.Api;
using Dev.ABGEO.UBill.SDK.Client;
using Dev.ABGEO.UBill.SDK.Model;

namespace Example
{
    public class GetDeliveryReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ubill.dev/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SmsApi(config);
            var smsID = 789L;  // long | Unique identifier of the SMS

            try
            {
                // Get Delivery Report
                DeliveryReportResponse result = apiInstance.GetDeliveryReport(smsID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsApi.GetDeliveryReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeliveryReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Delivery Report
    ApiResponse<DeliveryReportResponse> response = apiInstance.GetDeliveryReportWithHttpInfo(smsID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsApi.GetDeliveryReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsID** | **long** | Unique identifier of the SMS |  |

### Return type

[**DeliveryReportResponse**](DeliveryReportResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendsms"></a>
# **SendSMS**
> SendSMSResponse SendSMS (SMSPayload sMSPayload = null)

Send SMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Dev.ABGEO.UBill.SDK.Api;
using Dev.ABGEO.UBill.SDK.Client;
using Dev.ABGEO.UBill.SDK.Model;

namespace Example
{
    public class SendSMSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ubill.dev/v1";
            // Configure API key authorization: api_key
            config.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SmsApi(config);
            var sMSPayload = new SMSPayload(); // SMSPayload | SMS payload for sending messages (optional) 

            try
            {
                // Send SMS
                SendSMSResponse result = apiInstance.SendSMS(sMSPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsApi.SendSMS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendSMSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send SMS
    ApiResponse<SendSMSResponse> response = apiInstance.SendSMSWithHttpInfo(sMSPayload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsApi.SendSMSWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sMSPayload** | [**SMSPayload**](SMSPayload.md) | SMS payload for sending messages | [optional]  |

### Return type

[**SendSMSResponse**](SendSMSResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

