<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="ec80cee9-6823-42f3-ab6a-4260147ea879" Comment="Adapter Interface" Name="ADP_PRODUCTION_TOKEN" Namespace="UAO.Hackathon">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Flexbridge AB" Version="0.0" Author="Dmitrii" Date="12/17/2022" />
  <InterfaceList>
    <EventInputs>
      <Event Name="REQ" Comment="Request from Socket" />
    </EventInputs>
    <EventOutputs>
      <Event Name="CNF" Comment="Confirmation from Plug">
        <With Var="production" />
        <With Var="sorted" />
        <With Var="color" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="production" Type="STRING[255]" Comment="Request Data from Socket" />
      <VarDeclaration Name="color" Type="STRING[15]" Comment="Confirmation Data from Plug" />
      <VarDeclaration Name="sorted" Type="STRING[15]" Comment="Indication Data from Plug" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="production" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="production" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="color" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="color" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="sorted" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="sorted" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>