module App.Views.Sessions

open Fable.Helpers.React
open Fable.Helpers.React.Props
open App.Types


let session dispatch s =
  div [ Class "bg-white w-full rounded-lg shadow-lg p-2 md:p-8 mt-6" ]
    [ div [ Class "font-bold" ]
        [ str s.title ]

      div [ Class "mb-2 text-grey-dark text-sm" ]
        [ str s.date ]

      (match s.img with
      | Some pic ->
            img [ Class "w-full"
                  Src pic ]
      | None -> div [] [] )

      (match s.video with
      | Some stream ->
           div [ Class "videoframe" ]
             [ iframe [ Class "videostream"
                        AllowFullScreen true
                        Src stream
                        Scrolling "no"
                        FrameBorder 0 ]
                 [ ] ]
       | None -> div [] [])  
      
      div [ Class "py-2" ]
        [ str s.description ]
          
      div [ Class "mt-4 pt-2 border-t border-solid flex items-center justify-start flex-wrap" ]
        (s.links
        |> List.map (fun l ->
                a [ Class "link bg-grey-lighter hover:bg-grey-lightest rounded-lg shadow-md p-2 m-2"
                    Href l.url
                    Target "_blank"]
                  [ str l.label ] )) ] 
        
let sessions model dispatch =
  div [ Class "content bg-grey-lighter" ; Id "sessions"]
    [ div [ Class "my-8 w-4/5 lg:w-2/3 xl:w-1/2" ]
        [ h2 [ ]
                [ str "Sessions"]
          div [ Class "flex flex-col items-center justify-start" ]
            (model.sessions
            |> List.map (function Past_session s -> (session dispatch s) | Upcoming_session s -> (session dispatch s) ))
            
            ] ]