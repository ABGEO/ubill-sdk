# CreateBrandNameResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatusID** | **int64** | Response status code | 
**Message** | Pointer to **string** | Human-readable response message | [optional] 
**BrandID** | Pointer to **int64** | Brand identifier | [optional] 

## Methods

### NewCreateBrandNameResponse

`func NewCreateBrandNameResponse(statusID int64, ) *CreateBrandNameResponse`

NewCreateBrandNameResponse instantiates a new CreateBrandNameResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewCreateBrandNameResponseWithDefaults

`func NewCreateBrandNameResponseWithDefaults() *CreateBrandNameResponse`

NewCreateBrandNameResponseWithDefaults instantiates a new CreateBrandNameResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetStatusID

`func (o *CreateBrandNameResponse) GetStatusID() int64`

GetStatusID returns the StatusID field if non-nil, zero value otherwise.

### GetStatusIDOk

`func (o *CreateBrandNameResponse) GetStatusIDOk() (*int64, bool)`

GetStatusIDOk returns a tuple with the StatusID field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStatusID

`func (o *CreateBrandNameResponse) SetStatusID(v int64)`

SetStatusID sets StatusID field to given value.


### GetMessage

`func (o *CreateBrandNameResponse) GetMessage() string`

GetMessage returns the Message field if non-nil, zero value otherwise.

### GetMessageOk

`func (o *CreateBrandNameResponse) GetMessageOk() (*string, bool)`

GetMessageOk returns a tuple with the Message field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMessage

`func (o *CreateBrandNameResponse) SetMessage(v string)`

SetMessage sets Message field to given value.

### HasMessage

`func (o *CreateBrandNameResponse) HasMessage() bool`

HasMessage returns a boolean if a field has been set.

### GetBrandID

`func (o *CreateBrandNameResponse) GetBrandID() int64`

GetBrandID returns the BrandID field if non-nil, zero value otherwise.

### GetBrandIDOk

`func (o *CreateBrandNameResponse) GetBrandIDOk() (*int64, bool)`

GetBrandIDOk returns a tuple with the BrandID field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetBrandID

`func (o *CreateBrandNameResponse) SetBrandID(v int64)`

SetBrandID sets BrandID field to given value.

### HasBrandID

`func (o *CreateBrandNameResponse) HasBrandID() bool`

HasBrandID returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


