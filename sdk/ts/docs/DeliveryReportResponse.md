# DeliveryReportResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**statusID** | **number** | Response status code | [default to undefined]
**message** | **string** | Human-readable response message | [optional] [default to undefined]
**result** | [**Array&lt;DeliveryReportItem&gt;**](DeliveryReportItem.md) |  | [optional] [default to undefined]

## Example

```typescript
import { DeliveryReportResponse } from 'abgeo/ubill-sdk';

const instance: DeliveryReportResponse = {
    statusID,
    message,
    result,
};
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
