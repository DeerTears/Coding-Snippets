-- Single line comment

	--[[
	Block comment
	--]]

[[This is a string that,
when printed, will appear
on multiple lines]]

-- Concatenation
s1 = "This is a string "
s2 = "made with two parts."
endString = s1 .. s2

==
>
<
>=
<=
~=
and
or

elseif
-- semicolons aren't needed

local example = "Example text"
     
do
	local example = example .. " changed!"
	print(example)  -- Outputs 'Example text changed!'
end
print(example)  -- Outputs 'Example text'

    -- "Public" declaration
    local variableName
     
    -- "Private" declaration
    local _variableName
--semantic, fixed in luau

if not boolExpression then
	doSomething()
elseif otherBoolExpression then
	doSomething()
else
	doSomething()
end

