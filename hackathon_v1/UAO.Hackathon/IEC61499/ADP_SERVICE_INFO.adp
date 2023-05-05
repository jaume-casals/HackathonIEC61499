<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="420b27d2-7561-44be-96cb-ef1c278cd849" Comment="Adapter Interface" Name="ADP_SERVICE_INFO" Namespace="UAO.Hackathon">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Flexbridge AB" Version="0.0" Author="Dmitrii" Date="12/17/2022" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="UPD" Comment="Request from Socket">
        <With Var="SD_ID" />
        <With Var="mqtt_endpoint" />
        <With Var="request_topic" />
        <With Var="response_topic" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="SD_ID" Type="STRING[64]" Comment="Request Data from Socket" />
      <VarDeclaration Name="mqtt_endpoint" Type="STRING[64]" Comment="Response Data from Socket" />
      <VarDeclaration Name="request_topic" Type="STRING[64]" />
      <VarDeclaration Name="response_topic" Type="STRING[64]" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="UPD" Parameters="SD_ID" />
        <OutputPrimitive Interface="PLUG" Event="UPD" Parameters="SD_ID" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="CNFD" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="CNFD" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="INDD" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="INDD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="mqtt_endpoint" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="mqtt_endpoint" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>