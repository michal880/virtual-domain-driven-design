namespace VDDD

module Communities =

  open Fable.Helpers.React
  open Fable.Helpers.React.Props
  open VDDD.Types
  
    type Profile = {
    Image : string
    Location: string
    Date: string
    Website : string }
  
  let community (c:Community) =
    a [ Href c.url
        Target "_blank"
        Class "group floating-action-button bg-white w-full sm:w-48 rounded-lg shadow-md m-2 flex flex-col items-center justify-start" ]
      [ div [ Class "flex flex-col items-center justify-start" ]
          [
            div [ Class "m-2 h-8 font-semibold text-gray-800 text-sm text-center" ]
              [ str c.name ]
            img [ Class "my-2 w-64 object-contain"
                  Src c.img ] 
          ]
        div [ Class "text-gray-700 text-xs italic text-center" ]
          [ 
            str c.country 
            ( match c.city with
              | Some place -> str (", " + place)
              | None -> str "" )
          ] 
      ]
  
  let render model dispatch =
    div [ Class "content bg-gray-200" ; Id "communities"]
      [ div [ Class "w-full flex flex-col items-center justify-start" ]
          [ h2 [ Class "mt-6 w-4/5 lg:w-2/3 xl:w-1/2" ]
              [ str "Communities"]
              
            h3 [ Class "my-2 w-full text-center flex flex-col items-center justify-center" ]
              [ str "Check out the communities near you."
                div [ ] [ str "Are missing your own community? "] 
                     
                a [ Href "https://github.com/Baasie/virtual-domain-driven-design" 
                    Target "_blank" ]
                  [ str "Send us a pull request!" ]
              ]
            div [ Class "w-11/12 md:w-5/6" ]
                [ div [ Class "flex justify-center flex-wrap" ]
                    ( model.communities
                      |> List.map community )
                ]
            ]
      ]