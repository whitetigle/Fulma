module FulmaExtensions.Calendar.Types

type Model =
    { Intro : string
      BasicViewer : Viewer.Types.Model }

type Msg =
    | BasicViewerMsg of Viewer.Types.Msg
