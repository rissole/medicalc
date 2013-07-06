CREATE TABLE "battle_events" (
"id"  INTEGER NOT NULL,
"battle_id"  INTEGER NOT NULL,
"isBefore"  INTEGER NOT NULL DEFAULT 0,
"event"  TEXT NOT NULL DEFAULT "",
"name"  TEXT NOT NULL,
PRIMARY KEY ("id" ASC)
);
