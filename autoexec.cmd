@ECHO OFF
@BREAK OFF
CLS
PUSHD %~dp0
nuget restore CustomCampaign.sln
POPD
EXIT 0