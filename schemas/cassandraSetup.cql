DROP KEYSPACE IF EXISTS cooky;
DROP KEYSPACE IF EXISTS cookykeyspace;

CREATE KEYSPACE cooky WITH replication = {
  'class': 'SimpleStrategy',
  'replication_factor': 1
};

USE cooky;