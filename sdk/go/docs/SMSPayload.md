# SMSPayload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BrandID** | **int64** |  | 
**Numbers** | **[]int64** |  | 
**Text** | **string** |  | 
**StopList** | **bool** | Enable/disable checking numbers in the stop list | 

## Methods

### NewSMSPayload

`func NewSMSPayload(brandID int64, numbers []int64, text string, stopList bool, ) *SMSPayload`

NewSMSPayload instantiates a new SMSPayload object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSMSPayloadWithDefaults

`func NewSMSPayloadWithDefaults() *SMSPayload`

NewSMSPayloadWithDefaults instantiates a new SMSPayload object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetBrandID

`func (o *SMSPayload) GetBrandID() int64`

GetBrandID returns the BrandID field if non-nil, zero value otherwise.

### GetBrandIDOk

`func (o *SMSPayload) GetBrandIDOk() (*int64, bool)`

GetBrandIDOk returns a tuple with the BrandID field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetBrandID

`func (o *SMSPayload) SetBrandID(v int64)`

SetBrandID sets BrandID field to given value.


### GetNumbers

`func (o *SMSPayload) GetNumbers() []int64`

GetNumbers returns the Numbers field if non-nil, zero value otherwise.

### GetNumbersOk

`func (o *SMSPayload) GetNumbersOk() (*[]int64, bool)`

GetNumbersOk returns a tuple with the Numbers field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetNumbers

`func (o *SMSPayload) SetNumbers(v []int64)`

SetNumbers sets Numbers field to given value.


### GetText

`func (o *SMSPayload) GetText() string`

GetText returns the Text field if non-nil, zero value otherwise.

### GetTextOk

`func (o *SMSPayload) GetTextOk() (*string, bool)`

GetTextOk returns a tuple with the Text field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetText

`func (o *SMSPayload) SetText(v string)`

SetText sets Text field to given value.


### GetStopList

`func (o *SMSPayload) GetStopList() bool`

GetStopList returns the StopList field if non-nil, zero value otherwise.

### GetStopListOk

`func (o *SMSPayload) GetStopListOk() (*bool, bool)`

GetStopListOk returns a tuple with the StopList field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStopList

`func (o *SMSPayload) SetStopList(v bool)`

SetStopList sets StopList field to given value.



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


