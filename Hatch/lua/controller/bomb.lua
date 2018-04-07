-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt

local M = {}
M.type = "auxilliary"
M.relevantDevice = nil
M.defaultOrder = 1200

local max = math.max
local min = math.min
local minSpeed = 55 / 3.6

local function updateGFX(dt)
  if electrics.values.airspeed > minSpeed then
    electrics.values.bomblights = 1
  else
    electrics.values.bomblights = 0
  end
end

local function reset()
  electrics.values.bomblights = 0
end

local function init(jbeamData)
  electrics.values.bomblights = 0
end

M.init = init
M.reset = reset
M.updateGFX = updateGFX

return M