# \SmsAPI

All URIs are relative to *https://api.ubill.dev/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBalance**](SmsAPI.md#GetBalance) | **Get** /sms/balance | Get SMS Balance
[**GetBrandNames**](SmsAPI.md#GetBrandNames) | **Get** /sms/brandNames | Get All BrandNames
[**GetDeliveryReport**](SmsAPI.md#GetDeliveryReport) | **Get** /sms/report/{smsID} | Get Delivery Report
[**SendSMS**](SmsAPI.md#SendSMS) | **Post** /sms/send | Send SMS



## GetBalance

> SMSBalanceResponse GetBalance(ctx).Body(body).Execute()

Get SMS Balance

### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/abgeo/ubill-sdk/sdk/go"
)

func main() {
	body := interface{}(987) // interface{} |  (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SmsAPI.GetBalance(context.Background()).Body(body).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SmsAPI.GetBalance``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `GetBalance`: SMSBalanceResponse
	fmt.Fprintf(os.Stdout, "Response from `SmsAPI.GetBalance`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiGetBalanceRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **interface{}** |  | 

### Return type

[**SMSBalanceResponse**](SMSBalanceResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetBrandNames

> BrandNamesResponse GetBrandNames(ctx).Body(body).Execute()

Get All BrandNames

### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/abgeo/ubill-sdk/sdk/go"
)

func main() {
	body := interface{}(987) // interface{} |  (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SmsAPI.GetBrandNames(context.Background()).Body(body).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SmsAPI.GetBrandNames``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `GetBrandNames`: BrandNamesResponse
	fmt.Fprintf(os.Stdout, "Response from `SmsAPI.GetBrandNames`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiGetBrandNamesRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **interface{}** |  | 

### Return type

[**BrandNamesResponse**](BrandNamesResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDeliveryReport

> DeliveryReportResponse GetDeliveryReport(ctx, smsID).Body(body).Execute()

Get Delivery Report

### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/abgeo/ubill-sdk/sdk/go"
)

func main() {
	smsID := int64(789) // int64 | ID of SMS to get report for
	body := interface{}(987) // interface{} |  (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SmsAPI.GetDeliveryReport(context.Background(), smsID).Body(body).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SmsAPI.GetDeliveryReport``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `GetDeliveryReport`: DeliveryReportResponse
	fmt.Fprintf(os.Stdout, "Response from `SmsAPI.GetDeliveryReport`: %v\n", resp)
}
```

### Path Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**smsID** | **int64** | ID of SMS to get report for | 

### Other Parameters

Other parameters are passed through a pointer to a apiGetDeliveryReportRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **body** | **interface{}** |  | 

### Return type

[**DeliveryReportResponse**](DeliveryReportResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SendSMS

> SendSMSResponse SendSMS(ctx).SMSPayload(sMSPayload).Execute()

Send SMS

### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/abgeo/ubill-sdk/sdk/go"
)

func main() {
	sMSPayload := *openapiclient.NewSMSPayload(int64(123), []int64{int64(995511194241)}, "Text_example", false) // SMSPayload | Pet object that needs to be added to the store (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SmsAPI.SendSMS(context.Background()).SMSPayload(sMSPayload).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SmsAPI.SendSMS``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SendSMS`: SendSMSResponse
	fmt.Fprintf(os.Stdout, "Response from `SmsAPI.SendSMS`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSendSMSRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sMSPayload** | [**SMSPayload**](SMSPayload.md) | Pet object that needs to be added to the store | 

### Return type

[**SendSMSResponse**](SendSMSResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

