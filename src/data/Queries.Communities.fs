module VDDD.Data.Queries_communities

open VDDD.Types

let communities = 
    [
        {
              name = "DDD FR"
              country = "France"
              city = Some "Paris"
              url = "https://www.meetup.com/DDD-Paris/"
              img = "https://secure.meetupstatic.com/photos/event/8/8/0/9/600_476374825.jpeg"
        }
        {
              name = "DDD Budapest"
              country = "Hungary"
              city = Some "Budapest"
              url = "https://www.meetup.com/DDD-Practitioners-in-Budapest/"
              img = "https://secure.meetupstatic.com/photos/event/6/d/4/e/600_479247982.jpeg"
        }
        {
              name = "Domain Driven Design Nederland"
              country = "Netherlands"
              city = None
              url = "https://www.meetup.com/Domain-Driven-Design-Nederland/"
              img = "https://secure.meetupstatic.com/photos/event/b/8/b/5/600_448187285.jpeg"
        }
        {
              name = "Domain-Driven Design London"
              country = "United Kingdom"
              city = Some "London"
              url = "https://www.meetup.com/dddlondon/"
              img = "https://secure.meetupstatic.com/photos/event/7/e/a/6/600_483992422.jpeg"
        }
        {
              name = "DDD Belgium"
              country = "Belgium"
              city = None
              url = "http://dddbelgium.be/"
              img = "https://secure.meetupstatic.com/photos/event/d/0/0/6/600_433373254.jpeg"
        }
        {
              name = "DDDWRO"
              country = "Poland"
              city = Some "Wrocław"
              url = "http://dddwro.pl"
              img = "https://secure.meetupstatic.com/photos/event/3/9/6/f/600_488354703.jpeg"
        }
    ]
