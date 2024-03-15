using System.Reflection.Metadata;

public class FeatureCollection {
    public List<Feature> Features {get; set;} // Makes a list of features

    public class Feature {
        public Property Properties {get; set;} // The property is the only thing I need from the parent node. Is "node" a valid word for JSON?
    }

    public class Property {
        public string Place {get; set;} // I only need the Place and the Magnitude
        public decimal Mag {get; set;}
    }
}

// (parent): {                     //
//   type: "FeatureCollection",        // Okay, this is the target of the FeatureCollection class
//   metadata: {                           // Can check metadata, but I don't need to, so skip it 
//     generated: Long Integer,                //
//     url: String,                            //
//     title: String,                          //
//     api: String,                            //
//     count: Integer,                         //
//     status: Integer                         //
//   },                                        //
//   bbox: [                             // Can check bbox, but I don't need to, so skip it
//     minimum longitude,                      //
//     minimum latitude,                       //
//     minimum depth,                          //
//     maximum longitude,                      //
//     maximum latitude,                       //
//     maximum depth                           //
//   ],                                        //
//   features: [                         // Features is what I'm looking for. This has the information I'm looking for
//     {                                       //
//       type: "Feature",                      // I don't need this data
//       properties: {                         // I do need the information in here though
//         mag: Decimal,                           // This is the magnitude. I need this data
//         place: String,                          // This is the location. I need this data
//         time: Long Integer,                     // I don't need anything else
//         updated: Long Integer,                  //
//         tz: Integer,                            //
//         url: String,                            //
//         detail: String,                         //
//         felt:Integer,                           //
//         cdi: Decimal,                           //
//         mmi: Decimal,                           //
//         alert: String,                          //
//         status: String,                         //
//         tsunami: Integer,                       //
//         sig:Integer,                            //
//         net: String,                            //
//         code: String,                           //
//         ids: String,                            //
//         sources: String,                        //
//         types: String,                          //
//         nst: Integer,                           //
//         dmin: Decimal,                          //
//         rms: Decimal,                           //
//         gap: Decimal,                           //
//         magType: String,                        //
//         type: String                            //
//       },                                    //
//       geometry: {                           //
//         type: "Point",                          //
//         coordinates: [                          //
//           longitude,                                //
//           latitude,                                 //
//           depth                                     //
//         ]                                       //
//       },                                    //
//       id: String                            //
//     },                                  //
//     …                                   //
//   ]                                 //
// }                               //