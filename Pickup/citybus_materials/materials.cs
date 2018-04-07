
singleton Material(citybus)
{
    mapTo = "citybus";
    diffuseMap[2] = "vehicles/citybus/citybus_c.dds";
    specularMap[2] = "vehicles/citybus/citybus_s.dds";
    normalMap[2] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_d.dds";
    specularMap[1] = "vehicles/citybus/citybus_s.dds";
    normalMap[1] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/citybus/citybus_n.dds";
    overlayMap[2] = "";
    specular[0] = "0.5 0.5 0.5 0.1";
    specular[1] = "0.5 0.5 0.5 0.1";
    specular[2] = "0.5 0.5 0.5 0.1";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_seats)
{
   mapTo = "citybus_seats";
   normalMap[0] = "vehicles/citybus/citybus_intdetail_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   diffuseMap[1] = "vehicles/citybus/citybus_intdetail_d.dds";
   specularMap[0] = "vehicles/citybus/citybus_intdetail_s.dds";
   specularMap[1] = "vehicles/citybus/citybus_intdetail_s.dds";
   diffuseColor[0] = "0.3 0.3 0.45 1";
   diffuseColor[1] = "1 1 1 1.2";
   specular[0] = "0.5 0.5 0.5 0.95";
   specularPower[1] = "32";
   pixelSpecular[1] = "1";
   doubleSided = "0";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("citybus.skin.transit")
{
    mapTo = "citybus.skin.transit";
    colorPaletteMap[2] = "vehicles/citybus/citybus_skin_transit_palette_uv1.dds";
    OverlayMap[2] = "vehicles/citybus/citybus_skin_transit.dds";
    diffuseMap[2] = "vehicles/citybus/citybus_c.dds";
    specularMap[2] = "vehicles/citybus/citybus_s.dds";
    normalMap[2] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_d.dds";
    specularMap[1] = "vehicles/citybus/citybus_s.dds";
    normalMap[1] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/citybus/citybus_n.dds";
    specular[0] = "0.5 0.5 0.5 0.1";
    specular[1] = "0.5 0.5 0.5 0.1";
    specular[2] = "0.5 0.5 0.5 0.1";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("citybus_seats.skin.transit")
{
   mapTo = "citybus_seats.skin.transit";
   colorPaletteMap[0] = "vehicles/citybus/citybus_skin_transit_palette_uv1.dds";
   OverlayMap[0] = "vehicles/citybus/citybus_skin_transit.dds";
   normalMap[0] = "vehicles/citybus/citybus_intdetail_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   diffuseMap[1] = "vehicles/citybus/citybus_intdetail_d.dds";
   specularMap[0] = "vehicles/citybus/citybus_intdetail_s.dds";
   specularMap[1] = "vehicles/citybus/citybus_intdetail_s.dds";
   instanceDiffuse[0] = true;
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1.2";
   specular[0] = "0.5 0.5 0.5 0.95";
   specularPower[1] = "32";
   pixelSpecular[1] = "1";
   doubleSided = "0";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("citybus.skin.zebra")
{
    mapTo = "citybus.skin.zebra";
    OverlayMap[2] = "vehicles/citybus/citybus_skin_zebra.dds";
    diffuseMap[2] = "vehicles/citybus/citybus_c.dds";
    specularMap[2] = "vehicles/citybus/citybus_s.dds";
    normalMap[2] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_d.dds";
    specularMap[1] = "vehicles/citybus/citybus_s.dds";
    normalMap[1] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/citybus/citybus_n.dds";
    specular[0] = "0.5 0.5 0.5 0.1";
    specular[1] = "0.5 0.5 0.5 0.1";
    specular[2] = "0.5 0.5 0.5 0.1";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("citybus_seats.skin.zebra")
{
   mapTo = "citybus_seats.skin.zebra";
   OverlayMap[0] = "vehicles/citybus/citybus_skin_zebra.dds";
   normalMap[0] = "vehicles/citybus/citybus_intdetail_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   diffuseMap[1] = "vehicles/citybus/citybus_intdetail_d.dds";
   specularMap[0] = "vehicles/citybus/citybus_intdetail_s.dds";
   specularMap[1] = "vehicles/citybus/citybus_intdetail_s.dds";
   instanceDiffuse[0] = true;
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1.2";
   specular[0] = "0.5 0.5 0.5 0.95";
   specularPower[1] = "32";
   pixelSpecular[1] = "1";
   doubleSided = "0";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("citybus.skin.safari")
{
    mapTo = "citybus.skin.safari";
    diffuseMap[3] = "vehicles/citybus/citybus_dirt.dds";
	  diffuseMapUV[3] = 1;
    OverlayMap[2] = "vehicles/citybus/citybus_skin_safari.dds";
    diffuseMap[2] = "vehicles/citybus/citybus_c.dds";
    specularMap[2] = "vehicles/citybus/citybus_s.dds";
    normalMap[2] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_d.dds";
    specularMap[1] = "vehicles/citybus/citybus_s.dds";
    normalMap[1] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/citybus/citybus_n.dds";
    specular[0] = "0.5 0.5 0.5 0.1";
    specular[1] = "0.5 0.5 0.5 0.1";
    specular[2] = "0.5 0.5 0.5 0.1";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    diffuseColor[3] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    useAnisotropic[3] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("citybus_seats.skin.safari")
{
   mapTo = "citybus_seats.skin.safari";
   OverlayMap[0] = "vehicles/citybus/citybus_skin_safari.dds";
   normalMap[0] = "vehicles/citybus/citybus_intdetail_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   diffuseMap[1] = "vehicles/citybus/citybus_intdetail_d.dds";
   specularMap[0] = "vehicles/citybus/citybus_intdetail_s.dds";
   specularMap[1] = "vehicles/citybus/citybus_intdetail_s.dds";
   instanceDiffuse[0] = true;
   diffuseColor[0] = "1 1 1 1";
   diffuseColor[1] = "1 1 1 1.2";
   specular[0] = "0.5 0.5 0.5 0.95";
   specularPower[1] = "32";
   pixelSpecular[1] = "1";
   doubleSided = "0";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("citybus.skin.hero")
{
    mapTo = "citybus.skin.hero";
    OverlayMap[2] = "vehicles/citybus/citybus_skin_hero.dds";
    diffuseMap[2] = "vehicles/citybus/citybus_c.dds";
    specularMap[2] = "vehicles/citybus/citybus_s.dds";
    normalMap[2] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_d.dds";
    specularMap[1] = "vehicles/citybus/citybus_s.dds";
    normalMap[1] = "vehicles/citybus/citybus_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/citybus/citybus_n.dds";
    specular[0] = "0.5 0.5 0.5 0.1";
    specular[1] = "0.5 0.5 0.5 0.1";
    specular[2] = "0.5 0.5 0.5 0.1";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};


singleton Material(citybus_jato)
{
   mapTo = "citybus_jato";
    diffuseMap[0] = "vehicles/citybus/citybus_jato_d.dds";
    specularMap[0] = "vehicles/citybus/citybus_jato_s.dds";
    normalMap[0] = "vehicles/citybus/citybus_jato_n.dds";
    reflectivityMap[0] = "vehicles/citybus/citybus_jato_r.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    emissive[0] = "0";
    glow[0] = "0";
    translucentBlendOp = "None";
    cubemap = "global_cubemap_metalblurred";
    alphaTest = "0";
    alphaRef = "64";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(shockdiamonds_L)
{
    mapTo = "shockdiamonds_L";
};

singleton Material(shockdiamonds_R)
{
    mapTo = "shockdiamonds_R";
};

singleton Material(shockdiamonds_glow)
{
   mapTo = "shockdiamonds_glow";
   vertColor[0] = "1";
   diffuseMap[0] = "vehicles/citybus/shockdiamonds_d.dds";
   pixelSpecular[0] = "0";
   doubleSided = "0";
   emissive[0] = 1;
   glow[0] = 1;
   translucent = "1";
   translucentBlendOp = "addAlpha";
   animFlags[0] = "0x00000010";
   sequenceFramePerSec[0] = "120";
   sequenceSegmentSize[0] = "0.01";
   useAnisotropic[0] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(bomb_lights_flash)
{
   mapTo = "bomb_lights_flash";
   vertColor[0] = "1";
   diffuseMap[0] = "vehicles/citybus/bomb_lights.dds";
   pixelSpecular[0] = "0";
   doubleSided = "0";
   emissive[0] = 1;
   glow[0] = 1;
   translucent = "1";
   translucentBlendOp = "addAlpha";
   animFlags[0] = "0x00000010";
   sequenceFramePerSec[0] = "120";
   sequenceSegmentSize[0] = "0.04";
   useAnisotropic[0] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(bomb_lights_steady)
{
   mapTo = "bomb_lights_steady";
   vertColor[0] = "1";
   diffuseMap[0] = "vehicles/citybus/bomb_lights.dds";
   pixelSpecular[0] = "0";
   doubleSided = "0";
   emissive[0] = 1;
   glow[0] = 1;
   translucent = "1";
   translucentBlendOp = "addAlpha";
   animFlags[0] = "0x00000010";
   sequenceFramePerSec[0] = "120";
   sequenceSegmentSize[0] = "0.008";
   useAnisotropic[0] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(bomb_lights)
{
   mapTo = "bomb_lights";
};

singleton Material("citybus_sign.skin_signtype.flipdot")
{
    mapTo = "citybus_sign.skin_signtype.flipdot";
    diffuseMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/common/null.dds";
    diffuseMap[2] = "vehicles/citybus/citybus_d.dds";
    overlayMap[1] = "@busDestinationDsp";
    specularMap[2] = "vehicles/citybus/citybus_s.dds";
    glow[1] = "0";
    emissive[1] = "1";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.92 1.12 0.08 1"; //*1.15
    diffuseColor[2] = "2 2 2 1.1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("citybus_sign.skin_signtype.led_orange")
{
    mapTo = "citybus_sign.skin_signtype.led_orange";
    diffuseMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/common/null.dds";
    diffuseMap[2] = "vehicles/citybus/citybus_d.dds";
    overlayMap[1] = "@busDestinationDsp";
    specularMap[2] = "vehicles/citybus/citybus_s.dds";
    glow[1] = "1";
    emissive[1] = "1";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.75 0.82 0 1"; //*1.75
    diffuseColor[2] = "1.5 1.5 1.5 1.1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("citybus_sign_dmg.skin_signtype.flipdot")
{
    mapTo = "citybus_sign_dmg.skin_signtype.flipdot";
    diffuseMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/common/null.dds";
    diffuseMap[2] = "vehicles/citybus/citybus_d.dds";
    overlayMap[1] = "@busDestinationDsp";
    specularMap[2] = "vehicles/citybus/citybus_s.dds";
    glow[1] = "0";
    emissive[1] = "1";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.92 1.12 0.08 1"; //*1.15
    diffuseColor[2] = "2 2 2 1.1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("citybus_sign_dmg.skin_signtype.led_orange")
{
    mapTo = "citybus_sign_dmg.skin_signtype.led_orange";
    diffuseMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/common/null.dds";
    diffuseMap[2] = "vehicles/citybus/citybus_d.dds";
    specularMap[2] = "vehicles/citybus/citybus_s.dds";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0 0 0 1";
    diffuseColor[2] = "1.5 1.5 1.5 1.1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_signglass)
{
   mapTo = "citybus_signglass";
   diffuseColor[0] = "1 1 1 1.5";
   diffuseMap[0] = "vehicles/citybus/citybus_glass_d.dds";
   diffuseColor[1] = "1 1 1 0";
   specular[0] = "0.5 0.5 0.5 1";
   dynamicCubemap = "1";
   specularPower[0] = "50";
   translucent = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_glass)
{
    mapTo = "citybus_glass";
    reflectivityMap[0] = "vehicles/common/glass_base_2.dds";
    diffuseMap[0] = "vehicles/citybus/citybus_glass_d.dds";
    opacityMap[0] = "vehicles/citybus/citybus_glass_d.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_glass_da.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1.25 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_glass_dmg)
{
    mapTo = "citybus_glass_dmg";
    reflectivityMap[0] = "vehicles/citybus/citybus_glass_dmg_r.dds";
    diffuseMap[0] = "vehicles/citybus/citybus_glass_dmg_d.dds";
    opacityMap[0] = "vehicles/citybus/citybus_glass_dmg_d.dds";
    specularMap[0] = "vehicles/common/glass_dmg_s.dds";
    normalMap[0] = "vehicles/citybus/citybus_glass_dmg_n.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_glass_da.dds";
    specularMap[1] = "vehicles/common/glass_dmg_s.dds";
    normalMap[1] = "vehicles/citybus/citybus_glass_dmg_n.dds";
    specularPower[0] = "128";
    specularPower[1] = "128";
    diffuseColor[0] = "1.25 1.5 1.5 1";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_glass_int)
{
    mapTo = "citybus_glass_int";
    diffuseMap[0] = "vehicles/citybus/citybus_glass_d.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_glass_da.dds";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1.25 1.5 1.5 0.75";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    doubleSided = "0";
    alphaRef = "0";
    dynamicCubemap = false;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_glass_int_dmg)
{
    mapTo = "citybus_glass_int_dmg";
    diffuseMap[0] = "vehicles/citybus/citybus_glass_dmg_d.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_glass_da.dds";
    specularMap[0] = "vehicles/common/glass_dmg_s.dds";
    normalMap[0] = "vehicles/citybus/citybus_glass_dmg_n.dds";
    specularPower[0] = "128";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = false;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_gauges)
{
    mapTo = "citybus_gauges";
    diffuseMap[0] = "vehicles/citybus/citybus_gauges_d.dds";
    specularMap[0] = "vehicles/citybus/citybus_gauges_s.dds";
    normalMap[0] = "vehicles/citybus/citybus_gauges_n.dds";
    specularPower[0] = "64";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    diffuseColor[0] = "1.25 1.25 1.25 1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_gauges_on)
{
    mapTo = "citybus_gauges_on";
    diffuseMap[1] = "vehicles/citybus/citybus_gauges_g.dds";
    specularMap[1] = "vehicles/citybus/citybus_gauges_s.dds";
    normalMap[1] = "vehicles/citybus/citybus_gauges_n.dds";
    diffuseMap[0] = "vehicles/citybus/citybus_gauges_d.dds";
    specularMap[0] = "vehicles/citybus/citybus_gauges_s.dds";
    normalMap[0] = "vehicles/citybus/citybus_gauges_n.dds";
    diffuseMap[2] = "vehicles/citybus/citybus_gauges_g.dds";
    diffuseColor[0] = "1.25 1.25 1.25 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 0.35";
    specularPower[0] = "64";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    emissive[2] = "1";
    glow[2] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_decals_gauges_on)
{
    mapTo = "citybus_decals_gauges_on";
    diffuseMap[0] = "vehicles/citybus/citybus_gauges_g.dds";
    diffuseColor[0] = "1 1 1 1";
    diffuseMap[1] = "vehicles/citybus/citybus_gauges_g.dds";
    diffuseColor[1] = "1 1 1 0.35";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    glow[1] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle"; materialTag2 = "decal";
};


singleton Material(citybus_gauges_glass)
{
   mapTo = "citybus_gauges_glass";
   diffuseColor[0] = "0.2 0.2 0.2 0.25";
   diffuseMap[0] = "vehicles/common/null.dds";
   reflectivityMap[0] = "";
   diffuseMap[1] = "vehicles/citybus/citybus_glass_d.dds";
   diffuseColor[1] = "1.2 1 1 0.25";
   specular[0] = "0.5 0.5 0.5 0.1";
   dynamicCubemap = "1";
   specularPower[0] = "50";
   translucent = "1";
   cubemap = "global_cubemap_metalblurred";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_interior)
{
   mapTo = "citybus_interior";
   normalMap[0] = "vehicles/citybus/citybus_interior_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   diffuseMap[1] = "vehicles/citybus/citybus_interior_d.dds";
   specularMap[1] = "vehicles/citybus/citybus_interior_s.dds";
   diffuseColor[0] = "1 1 1 0";
   diffuseColor[1] = "1 1 1 1";
   specular[0] = "0.5 0.5 0.5 0.95";
   dynamicCubemap = "1";
   specularPower[1] = "32";
   pixelSpecular[1] = "1";
   doubleSided = "0";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_intdetail)
{
   mapTo = "citybus_intdetail";
   normalMap[0] = "vehicles/citybus/citybus_intdetail_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   diffuseMap[1] = "vehicles/citybus/citybus_intdetail_d.dds";
   specularMap[1] = "vehicles/citybus/citybus_intdetail_s.dds";
   diffuseColor[0] = "1 1 1 0";
   diffuseColor[1] = "1 1 1 1";
   specular[0] = "0.5 0.5 0.5 0.95";
   dynamicCubemap = false;
   cubemap = "global_cubemap_metalblurred";
   specularPower[1] = "32";
   pixelSpecular[1] = "1";
   doubleSided = "0";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_engine)
{
    mapTo = "citybus_engine";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_engine_d.dds";
    normalMap[1] = "vehicles/citybus/citybus_engine_n.dds";
    normalMap[0] = "vehicles/citybus/citybus_engine_n.dds";
    specularMap[1] = "vehicles/citybus/citybus_engine_s.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    diffuseColor[1] = "1 1 1 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_systems)
{
    mapTo = "citybus_systems";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseMap[1] = "vehicles/citybus/citybus_systems_d.dds";
    normalMap[1] = "vehicles/citybus/citybus_systems_n.dds";
    normalMap[0] = "vehicles/citybus/citybus_systems_n.dds";
    specularMap[1] = "vehicles/citybus/citybus_systems_s.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    diffuseColor[1] = "1 1 1 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_cape1)
{
    mapTo = "citybus_cape1";
    diffuseMap[0] = "vehicles/citybus/citybus_cape_d.dds";
    specularMap[0] = "vehicles/citybus/citybus_cape_s.dds";
    normalMap[0] = "vehicles/citybus/citybus_cape_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1 1 1 1";
    dynamicCubemap = true;
};

singleton Material(citybus_intdisplay)
{
   mapTo = "citybus_intdisplay";
   normalMap[0] = "vehicles/citybus/citybus_intdisplay_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   diffuseMap[1] = "vehicles/citybus/citybus_intdisplay_d.dds";
   specularMap[1] = "vehicles/citybus/citybus_intdisplay_s.dds";
   diffuseColor[0] = "1 1 1 0";
   diffuseColor[1] = "0.5 0.5 0.5 1";
   specular[0] = "0.5 0.5 0.5 0.95";
   dynamicCubemap = false;
   cubemap = "global_cubemap_metalblurred";
   specularPower[1] = "2";
   pixelSpecular[1] = "1";
   doubleSided = "0";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_nextStop_DSP)
{
   mapTo = "citybus_nextStop_DSP";
   normalMap[0] = "";
   diffuseMap[0] = "vehicles/common/null.dds";
   diffuseMap[1] = "@busNextStopDsp";
   specularMap[1] = "";
   diffuseColor[0] = "1 1 1 0";
   diffuseColor[1] = "1 1 1 0.75";
   specular[0] = "1 1 1 0.95";
   dynamicCubemap = false;
   cubemap = "global_cubemap_metalblurred";
   specularPower[1] = "32";
   pixelSpecular[1] = "1";
   doubleSided = "0";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citbus_lcd_dmg)
{
   mapTo = "citbus_lcd_dmg";
   normalMap[0] = "vehicles/citybus/citybus_lcd_dmg_n.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   diffuseMap[1] = "vehicles/citybus/citybus_lcd_dmg_d.dds";
   specularMap[1] = "vehicles/citybus/citybus_lcd_dmg_s.dds";
   diffuseColor[0] = "1 1 1 0";
   diffuseColor[1] = "1 1 1 0.75";
   specular[0] = "1 1 1 1";
   dynamicCubemap = false;
   cubemap = "global_cubemap_metalblurred";
   specularPower[1] = "32";
   pixelSpecular[1] = "1";
   doubleSided = "0";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_transmission_DSP)
{
   mapTo = "citybus_transmission_DSP";
   diffuseColor[0] = "1 1 1 0.75";
   diffuseMap[0] = "vehicles/citybus/citybus_transmission_DSP.dds";
   reflectivityMap[0] = "";
   diffuseMap[1] = "vehicles/citybus/citybus_transmission_DSP.dds";
   diffuseColor[1] = "1 1 1 0.5";
   specular[0] = "0.5 0.5 0.5 0.1";
   dynamicCubemap = "1";
   specularPower[0] = "50";
   glow[0] = "1";
   glow[1] = "0";
   emissive[0] = "1";
   emissive[1] = "0";
   translucent = "1";
   cubemap = "global_cubemap_metalblurred";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(citybus_sign)
{
    mapTo = "citybus_sign";
};

singleton Material(citybus_sign_dmg)
{
    mapTo = "citybus_sign_dmg";
};

singleton Material(citybus_signal_R)
{
   mapTo = "citybus_signal_R";
};

singleton Material(citybus_taillight)
{
   mapTo = "citybus_taillight";
};

singleton Material(citybus_reverselight)
{
   mapTo = "citybus_reverselight";
};

singleton Material(citybus_signal_L)
{
   mapTo = "citybus_signal_L";
};

singleton Material(citybus_lowbeam)
{
   mapTo = "citybus_lowbeam";
};

singleton Material(citybus_highbeam)
{
   mapTo = "citybus_highbeam";
};

singleton Material(citybus_runninglight)
{
   mapTo = "citybus_runninglight";
};

singleton Material(citybus_kneel)
{
   mapTo = "citybus_kneel";
};

singleton Material(citybus_dooropen)
{
   mapTo = "citybus_dooropen";
};

singleton Material(citybus_stoprequest)
{
   mapTo = "citybus_stoprequest";
};

singleton Material(citybus_rideheight)
{
   mapTo = "citybus_rideheight";
};

singleton Material(citybus_transmission_DSP_R)
{
   mapTo = "citybus_transmission_DSP_R";
};

singleton Material(citybus_transmission_DSP_N)
{
   mapTo = "citybus_transmission_DSP_N";
};

singleton Material(citybus_transmission_DSP_1)
{
   mapTo = "citybus_transmission_DSP_1";
};

singleton Material(citybus_transmission_DSP_2)
{
   mapTo = "citybus_transmission_DSP_2";
};

singleton Material(citybus_transmission_DSP_3)
{
   mapTo = "citybus_transmission_DSP_3";
};

singleton Material(citybus_transmission_DSP_4)
{
   mapTo = "citybus_transmission_DSP_4";
};

singleton Material(citybus_transmission_DSP_5)
{
   mapTo = "citybus_transmission_DSP_5";
};

singleton Material(citybus_transmission_DSP_6)
{
   mapTo = "citybus_transmission_DSP_6";
};