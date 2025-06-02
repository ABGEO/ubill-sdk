# BrandNamesResponse


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**statusID** | **number** | Response status code | [default to undefined]
**message** | **string** | Human-readable response message | [optional] [default to undefined]
**brands** | [**Array&lt;BrandName&gt;**](BrandName.md) | List of available brand names | [default to undefined]

## Example

```typescript
import { BrandNamesResponse } from 'abgeo/ubill-sdk';

const instance: BrandNamesResponse = {
    statusID,
    message,
    brands,
};
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
