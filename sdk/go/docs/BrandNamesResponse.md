# BrandNamesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatusID** | **int64** |  | 
**Brands** | Pointer to [**[]BrandName**](BrandName.md) |  | [optional] 

## Methods

### NewBrandNamesResponse

`func NewBrandNamesResponse(statusID int64, ) *BrandNamesResponse`

NewBrandNamesResponse instantiates a new BrandNamesResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewBrandNamesResponseWithDefaults

`func NewBrandNamesResponseWithDefaults() *BrandNamesResponse`

NewBrandNamesResponseWithDefaults instantiates a new BrandNamesResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetStatusID

`func (o *BrandNamesResponse) GetStatusID() int64`

GetStatusID returns the StatusID field if non-nil, zero value otherwise.

### GetStatusIDOk

`func (o *BrandNamesResponse) GetStatusIDOk() (*int64, bool)`

GetStatusIDOk returns a tuple with the StatusID field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStatusID

`func (o *BrandNamesResponse) SetStatusID(v int64)`

SetStatusID sets StatusID field to given value.


### GetBrands

`func (o *BrandNamesResponse) GetBrands() []BrandName`

GetBrands returns the Brands field if non-nil, zero value otherwise.

### GetBrandsOk

`func (o *BrandNamesResponse) GetBrandsOk() (*[]BrandName, bool)`

GetBrandsOk returns a tuple with the Brands field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetBrands

`func (o *BrandNamesResponse) SetBrands(v []BrandName)`

SetBrands sets Brands field to given value.

### HasBrands

`func (o *BrandNamesResponse) HasBrands() bool`

HasBrands returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


