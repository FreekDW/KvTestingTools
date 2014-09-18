KvTestingTools
==============

Usage:

Spookfiles KvA:

[wim@CN001 Release]$ mono Spookfiles.Testing.KvA.CLI.exe
Spookfiles.Testing.KvA 1.0.0.0
Copyright ©  2014

  --Connectivity     (Default: False) Run the connectivity tests

  --Functionality    (Default: False) Run the functionality tests

  --Security         (Default: False) Run the security tests

  --Performance      (Default: False) Run the performance tests

  --Continuity       (Default: False) Run the continuity tests

  --All              (Default: False) Run all tests

  --Url              Required. The base url of the host to check/connect to

  --ApiKey           The actual api key

  --ApiKeyHeader     The header name of the api key. By default the program 
                     will try to use ApiKey

  --User             The username to use for basic Auth. Note: you can combine 
                     this with api key if you want.

  --Pass             The pass to use for basic Auth




Spookfiles KvG:

[wim@CN001 Release]$ mono Spookfiles.Testing.CLI.exe
Spookfiles.Testing 1.0.0.0
Copyright ©  2014

  --Connectivity     (Default: False) Run the connectivity tests

  --Functionality    (Default: False) Run the functionality tests

  --Security         (Default: False) Run the security tests

  --Performance      (Default: False) Run the performance tests

  --Continuity       (Default: False) Run the continuity tests

  --All              (Default: False) Run all tests

  --Url              Required. The base url of the host to check/connect to

  --ApiKey           The actual api key

  --ApiKeyHeader     The header name of the api key. By default the program 
                     will try to use ApiKey

  --User             The username to use for basic Auth. Note: you can combine 
                     this with api key if you want.

  --Pass             The pass to use for basic Auth



Remark: There may be some parameters that you want to adjust in the Options class. 


