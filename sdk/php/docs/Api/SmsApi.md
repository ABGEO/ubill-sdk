# ABGEO\UBill\Sdk\SmsApi

All URIs are relative to https://api.ubill.dev/v1, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**getBalance()**](SmsApi.md#getBalance) | **GET** /sms/balance | Get SMS Balance |
| [**getBrandNames()**](SmsApi.md#getBrandNames) | **GET** /sms/brandNames | Get All BrandNames |
| [**getDeliveryReport()**](SmsApi.md#getDeliveryReport) | **GET** /sms/report/{smsID} | Get Delivery Report |
| [**sendSMS()**](SmsApi.md#sendSMS) | **POST** /sms/send | Send SMS |


## `getBalance()`

```php
getBalance($body): \ABGEO\UBill\Sdk\Model\SMSBalanceResponse
```

Get SMS Balance

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure API key authorization: api_key
$config = ABGEO\UBill\Sdk\Configuration::getDefaultConfiguration()->setApiKey('key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = ABGEO\UBill\Sdk\Configuration::getDefaultConfiguration()->setApiKeyPrefix('key', 'Bearer');


$apiInstance = new ABGEO\UBill\Sdk\Api\SmsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = NULL; // mixed

try {
    $result = $apiInstance->getBalance($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SmsApi->getBalance: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **body** | **mixed**|  | [optional] |

### Return type

[**\ABGEO\UBill\Sdk\Model\SMSBalanceResponse**](../Model/SMSBalanceResponse.md)

### Authorization

[api_key](../../README.md#api_key)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`, `text/plain`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `getBrandNames()`

```php
getBrandNames($body): \ABGEO\UBill\Sdk\Model\BrandNamesResponse
```

Get All BrandNames

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure API key authorization: api_key
$config = ABGEO\UBill\Sdk\Configuration::getDefaultConfiguration()->setApiKey('key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = ABGEO\UBill\Sdk\Configuration::getDefaultConfiguration()->setApiKeyPrefix('key', 'Bearer');


$apiInstance = new ABGEO\UBill\Sdk\Api\SmsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = NULL; // mixed

try {
    $result = $apiInstance->getBrandNames($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SmsApi->getBrandNames: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **body** | **mixed**|  | [optional] |

### Return type

[**\ABGEO\UBill\Sdk\Model\BrandNamesResponse**](../Model/BrandNamesResponse.md)

### Authorization

[api_key](../../README.md#api_key)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`, `text/plain`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `getDeliveryReport()`

```php
getDeliveryReport($smsID, $body): \ABGEO\UBill\Sdk\Model\DeliveryReportResponse
```

Get Delivery Report

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure API key authorization: api_key
$config = ABGEO\UBill\Sdk\Configuration::getDefaultConfiguration()->setApiKey('key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = ABGEO\UBill\Sdk\Configuration::getDefaultConfiguration()->setApiKeyPrefix('key', 'Bearer');


$apiInstance = new ABGEO\UBill\Sdk\Api\SmsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$smsID = 56; // int | ID of SMS to get report for
$body = NULL; // mixed

try {
    $result = $apiInstance->getDeliveryReport($smsID, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SmsApi->getDeliveryReport: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **smsID** | **int**| ID of SMS to get report for | |
| **body** | **mixed**|  | [optional] |

### Return type

[**\ABGEO\UBill\Sdk\Model\DeliveryReportResponse**](../Model/DeliveryReportResponse.md)

### Authorization

[api_key](../../README.md#api_key)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`, `text/plain`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `sendSMS()`

```php
sendSMS($sMSPayload): \ABGEO\UBill\Sdk\Model\SendSMSResponse
```

Send SMS

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure API key authorization: api_key
$config = ABGEO\UBill\Sdk\Configuration::getDefaultConfiguration()->setApiKey('key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = ABGEO\UBill\Sdk\Configuration::getDefaultConfiguration()->setApiKeyPrefix('key', 'Bearer');


$apiInstance = new ABGEO\UBill\Sdk\Api\SmsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$sMSPayload = new \ABGEO\UBill\Sdk\Model\SMSPayload(); // \ABGEO\UBill\Sdk\Model\SMSPayload | Pet object that needs to be added to the store

try {
    $result = $apiInstance->sendSMS($sMSPayload);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SmsApi->sendSMS: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **sMSPayload** | [**\ABGEO\UBill\Sdk\Model\SMSPayload**](../Model/SMSPayload.md)| Pet object that needs to be added to the store | [optional] |

### Return type

[**\ABGEO\UBill\Sdk\Model\SendSMSResponse**](../Model/SendSMSResponse.md)

### Authorization

[api_key](../../README.md#api_key)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`, `text/plain`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
