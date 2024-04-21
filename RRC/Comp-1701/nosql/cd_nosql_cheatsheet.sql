/* 
** Name: Cole Dorman
** nosql commands
** Date: 1/23/2024
** History:
**           1/23/2024 - added changelog
**           1/26/2024 - added notes on the database loading
**/


-- show db commands
dbs.help()

-- connect to cli --> select MY_MDB_ORG
atlas auth login
-- config login
atlas config set

-- CONNECTING
    -- connection string
    MY_ATLAS_CONNECTION_STRING=$(atlas clusters connectionStrings describe myAtlasClusterEDU | sed "1 d")
    mongosh -u myAtlasDBUser -p myatlas-001 $MY_ATLAS_CONNECTION_STRING
    -- test connection
    db.hello()
-- DOCUMENTS
    -- SYNTAX
    {
        field: "value",
        field2: 7
    }
    -- insertion
        -- insert one
        db.myCollection.insertOne({field: "value"})
        -- insert many
        db.myCollection.insertMany([{field: "value"}, {field: "value2"}])
    -- QUERYING
        -- find all
        db.myCollection.find()
        -- find $in operator returns documents where the field is equal to any value in the array
        db.myCollection.find({field: {$in: ["value", "value2"]}})
        $elemMatch --> returns documents where the field is an array that contains at least one element that matches the query
        -- count documents
            db.myCollection.countDocuments()
    -- OPERATORS
        $gt --> greater than
        $lt --> less than
        $gte --> greater than or equal to
        $lte --> less than or equal to
        $eq --> equal to
        $and --> logical and
        $or --> logical or
        -- find EXAMPLE
            db.myCollection.find({
                $and: [
                    {age: {$gt: 20, $lt: 30}},
                    {$or: [
                        {status: {$eq: 'A'}},
                        {type: {$eq: 'premium'}}
                    ]}
                ]
            })
        -- replace EXAMPLE
            db.myCollection.replaceOne(
                {field: "value"},
                {field: "newValue"}
            )
    -- UPDATING
        -- update one
        db.myCollection.updateOne(
            {field: "value"}, -- query
            {$set: {field: "newValue"}} -- update
        )
        -- update many
        db.myCollection.updateMany(
            {field: "value"},
            {$set: {field: "newValue"}}
        )
        -- upsert
        db.mycollection.upsert(
            {field: "value"},
            {$set: {field: "newValue"}},
            {upsert: true}
        )
        -- find and modify
        db.myCollection.findAndModify({
            query: {_id: "objectid"},
            update: {$inc: {field: "newValue"} },
            new: true,
        })
    -- DELETING
        -- delete one
        db.myCollection.deleteOne({field: "value"})
        -- delete many
        db.myCollection.deleteMany({field: "value"})
        -- drop collection
        db.myCollection.drop()
    -- AGGREGATION
        -- aggregate
        db.collection.aggregate([
            {
                $stage1: {
                    { expression1 },
                    { expression2 }...
                },
                $stage2: {
                    { expression1 }...
                }
            }])
        -- sort
        db.collection.aggregate([
            {$sort: {field: 1}}
        ])
        -- limit
        db.collection.aggregate([
            {$limit: 5}
        ])
        -- match
        db.collection.aggregate([
            {$match: {field: "value"}}
        ])
        -- group
        db.collection.aggregate([
            {$group: {_id: "$field", total: {$sum: 1}}}
        ])
        -- count
        db.collection.aggregate([
            {$count: "total"}
        ])
        -- project
        db.collection.aggregate([
            {$project: {field: 1, _id: 0}}
        ])
        -- out
        db.collection.aggregate([
            {$out: "newCollection"}
        ])
    -- INDEXES
        -- create index
        db.collection.createIndex({field: 1})
        -- list indexes
        db.collection.getIndexes()
        -- check if index used in query
        -- params IXSCAN, COLLSCAN, FETCH, SORT
        db.collection.explain().find({field: "value"})
    -- MULTIKEY INDEXES
        -- create multikey index
        db.collection.createIndex({field: 1, field2: 1})
        -- find index
        db.collection.explain().find({field: "value"})
    -- DELETING INDEXES
        -- drop index
        db.collection.dropIndex({field: 1})
        -- drop index by name
        db.collection.dropIndex("field_1")
        -- drop multiple indexes
        db.collection.dropIndexes()
-- SEARCHING
    -- search
        $search {
        "compound": {
            "must": [{
            "text": {
                "query": "field",
                "path": "habitat"
            }
            }],
            "should": [{
            "range": {
                "gte": 45,
                "path": "wingspan_cm",
                "score": {"constant": {"value": 5}}
            }
            }]
        }
        }
    -- search meta
        $searchMeta: {
        "facet": {
            "operator": {
                "text": {
                "query": ["Northern Cardinal"],
                "path": "common_name"
                }
            },
            "facets": {
                "sightingWeekFacet": {
                    "type": "date",
                    "path": "sighting",
                    "boundaries": [ISODate("2022-01-01"), 
                        ISODate("2022-01-08"),
                        ISODate("2022-01-15"),
                        ISODate("2022-01-22")],
                    "default" : "other"
                }
            }
        }
        }
    -- transactions
        -- start session
        session = db.getMongo().startSession()
        -- start transaction
        session.startTransaction()
        -- commit transaction
        session.commitTransaction()
        -- abort transaction
        session.abortTransaction()
        -- end session
        session.endSession()
