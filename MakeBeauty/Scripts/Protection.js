var systemRegistry = "HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\\System\\";

function computerCode() {
    var shell = new ActiveXObject("WScript.Shell");

    var environment = shell.Environment

    return environment.Item("MAKEBEAUTY_CODE");
    //return processorCode() + biosCode() + multifunctionAdapterCode();
}

function processorCode() {
   

    var result = shell.RegRead(systemRegistry + "CentralProcessor\\0\\Identifier");
    result += shell.RegRead(systemRegistry + "CentralProcessor\\0\\ProcessorNameString");
    result += shell.RegRead(systemRegistry + "CentralProcessor\\0\\VendorIdentifier");
    //result += shell.RegRead(systemRegistry + "CentralProcessor\\0\\Component Information");
    //result += shell.RegRead(systemRegistry + "CentralProcessor\\0\\FeatureSet");
    //result += shell.RegRead(systemRegistry + "CentralProcessor\\0\\Platform Specific Field 1");
    //result += shell.RegRead(systemRegistry + "CentralProcessor\\0\\Previous Update Revision");
    //result += shell.RegRead(systemRegistry + "CentralProcessor\\0\\Update Revision");
    //result += shell.RegRead(systemRegistry + "CentralProcessor\\0\\Update Status");

    return result;
}

function biosCode() {
    var shell = new ActiveXObject("WScript.Shell");

    var result = shell.RegRead(systemRegistry + "BIOS\\BaseBoardManufacturer");
    result += shell.RegRead(systemRegistry + "BIOS\\BaseBoardProduct");
    result += shell.RegRead(systemRegistry + "BIOS\\SystemVersion");
    result += shell.RegRead(systemRegistry + "BIOS\\SystemProductName");
    result += shell.RegRead(systemRegistry + "BIOS\\SystemSKU");
    result += shell.RegRead(systemRegistry + "BIOS\\SystemProductName");
    result += shell.RegRead(systemRegistry + "BIOS\\SystemManufacturer");
    result += shell.RegRead(systemRegistry + "BIOS\\SystemFamily");
    result += shell.RegRead(systemRegistry + "BIOS\\BIOSVersion");
    result += shell.RegRead(systemRegistry + "BIOS\\BIOSVendor");
    result += shell.RegRead(systemRegistry + "BIOS\\BIOSReleaseDate");
    //result += shell.RegRead(systemRegistry + "BIOS\\BiosMajorRelease");
    //result += shell.RegRead(systemRegistry + "BIOS\\BiosMinorRelease");
    //result += shell.RegRead(systemRegistry + "BIOS\\ECFirmwareMajorRelease");
    //result += shell.RegRead(systemRegistry + "BIOS\\ECFirmwareMinorRelease");

    return result;
}

function multifunctionAdapterCode() {
    var shell = new ActiveXObject("WScript.Shell");

    var result = shell.RegRead(systemRegistry + "MultifunctionAdapter\\0\\Identifier");
    result += shell.RegRead(systemRegistry + "MultifunctionAdapter\\1\\Identifier");
    result += shell.RegRead(systemRegistry + "MultifunctionAdapter\\2\\Identifier");
    result += shell.RegRead(systemRegistry + "MultifunctionAdapter\\3\\Identifier");
    result += shell.RegRead(systemRegistry + "MultifunctionAdapter\\4\\Identifier");
    result += shell.RegRead(systemRegistry + "MultifunctionAdapter\\5\\Identifier");
    result += shell.RegRead(systemRegistry + "MultifunctionAdapter\\6\\Identifier");
    result += shell.RegRead(systemRegistry + "MultifunctionAdapter\\7\\Identifier");
    result += shell.RegRead(systemRegistry + "MultifunctionAdapter\\8\\Identifier");
    result += shell.RegRead(systemRegistry + "MultifunctionAdapter\\9\\Identifier");
    result += shell.RegRead(systemRegistry + "MultifunctionAdapter\\10\\Identifier");

    return result;
}

