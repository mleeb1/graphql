# graphql

This repository contains a sample GraphQL .NET project for ASP.NET Core

## See

https://app.pluralsight.com/library/courses/building-graphql-apis-aspdotnet-core/table-of-contents

## Setup

To setup the Database, go to: (in VS, Menu) Toools --> NuGet Package Manager --> Package Manager Console
Then run: Update-Database (select "A" for All if prompted). This will setup the local SQL DB.

## Debugging / Running the sample GraphQL query

Hit F5 to run and then enter this query (JSON) and hit the run / play icon in UI Playground when it loads to select all Owners and their policies:

{
  owners {
    id
    name
    policies {
      name
      type
    }
  }
}
