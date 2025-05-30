<?php

require_once(__DIR__ . '/../vendor/autoload.php');

use ABGEO\UBill\Sdk\Configuration;
use ABGEO\UBill\Sdk\Api\SmsApi;


$config = Configuration::getDefaultConfiguration()->setApiKey('key', '<api-key-goes-here>');
$apiInstance = new SmsApi(config: $config);

try {
    $result = $apiInstance->getBalance();

    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SmsApi->getBalance: ', $e->getMessage(), PHP_EOL;
}
