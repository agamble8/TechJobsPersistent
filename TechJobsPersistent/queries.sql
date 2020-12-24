--Part 1
jobskills.SkillId
-- Jobs table:
-- Id - int
-- Name - lontext
-- EmployerId - int

--Part 2
SELECT Name
FROM employers
WHERE location = "St. Louis";

--Part 3
SELECT DISTINCT name, description
FROM skills
JOIN jobskills ON skills.Id = jobskills.SkillId;
ORDER BY name ASC;
